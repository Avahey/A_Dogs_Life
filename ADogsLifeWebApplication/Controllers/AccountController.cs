using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ADogsLifeWebApplication.Models.Users;
using ADogsLifeWebApplication.ViewModels.Account;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SignInResult = Microsoft.AspNetCore.Identity.SignInResult;

namespace ADogsLifeWebApplication.Controllers
{
    
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IDogRepository _dogRepository;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ILogger<AccountController> _logger;

        public AccountController(UserManager<ApplicationUser> userManager, IDogRepository dogRepository,  IWebHostEnvironment webHostEnvironment, SignInManager<ApplicationUser> signInManager, ILogger<AccountController> logger)
        {
            _userManager = userManager;
            _dogRepository = dogRepository;
            _webHostEnvironment = webHostEnvironment;
            _signInManager = signInManager;
            _logger = logger;
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            ApplicationUser user = new ApplicationUser
            {
                UserName = model.Email,
                Email = model.Email,
                PhoneNumber = model.PhoneNumber,
                FirstName = model.FirstName,
                LastName = model.LastName,
                FullName = model.FirstName + " " + model.LastName,
                Country = model.Country,
                Description = model.Description,
            };

            string uniqueFileName = ProcessUploadedPhoto(model.Photo, user.Id);
            user.PhotoPath = uniqueFileName;
            
            IdentityResult result = await _userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                if (_signInManager.IsSignedIn(User) && User.IsInRole("Admin"))
                {
                    return RedirectToAction("ListUsers", "Administration");
                }
                await _signInManager.SignInAsync(user, isPersistent: false);
                return RedirectToAction("ViewProfile", "Account", new {user.Id});
            }

            foreach (IdentityError error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> RegisterDog(RegisterDogViewModel model, string id)
        {
            if (!ModelState.IsValid) return View(model);
            ApplicationUser user = await _userManager.FindByIdAsync(id);
            
            //throw new Exception("Error");
            if (user == null)
            {
                _logger.LogError($"User not found with Id= {id} while trying to register a dog. 404 status code thrown.");
                Response.StatusCode = 404;
                return View("~/Views/Error/UserNotFound.cshtml");
            }
            
            Dog dog = new Dog
            {
                Id = Guid.NewGuid(),
                IdParent = id,
                FirstName = model.FirstName,
                MiddleName = model.MiddleName,
                LastName = user.LastName,
                FullName = model.FirstName + " " + model.MiddleName + " " + user.LastName,
                Description = model.Description,
                FavoriteToy = model.FavoriteToy,
                Breed = model.Breed
            };

            string uniqueFileName = ProcessUploadedPhoto(model.Photo, dog.Id.ToString());
            dog.PhotoPath = uniqueFileName;

            _dogRepository.Add(dog);

            if (_dogRepository.GetAllDogs().Contains(dog))
            {
                if (_signInManager.IsSignedIn(User) && User.IsInRole("Admin"))
                {
                    return RedirectToAction("ListUsers", "Administration");
                }
                await _signInManager.SignInAsync(user, isPersistent: false);
                return RedirectToAction("ViewDog", "Account", new {dog.Id});
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult RegisterDog(string id)
        {
            ViewBag.Id = id; //Parent Id
            return View();
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("Account/ViewDog/{id?}")]
        public IActionResult ViewDog(Guid id)
        {
            Dog dog = _dogRepository.GetDog(id);
            
            //throw new Exception("Error");
            if (dog == null)
            {
                _logger.LogError($"Dog not found with Id= {id} while getting details. 404 status code thrown.");
                Response.StatusCode = 404;
                return View("~/Views/Error/UserNotFound.cshtml");
            }
            
            DogDetailsViewModel dogDetailsViewModel = new DogDetailsViewModel()
            {
                Dog = dog,
                PageTitle = dog.FirstName + " Details"
            };

            return View(dogDetailsViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Landing", "Home");
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl)
        {
            if (!ModelState.IsValid) return View(model);
            SignInResult result =
                await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);

            if (result.Succeeded)
            {
                if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                {
                    return Redirect(returnUrl);
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }

            ModelState.AddModelError(string.Empty, "Invalid Login Attempt");
            return View(model);
        }
        
        [AllowAnonymous]
        [HttpGet]
        public IActionResult AccessDenied()
        {
            return View("~/Views/Error/AccessDenied.cshtml");
        }

        [AcceptVerbs("Get", "Post")]
        [AllowAnonymous]
        public async Task<IActionResult> IsEmailInUse(string email)
        {
            ApplicationUser user = await _userManager.FindByEmailAsync(email);

            return user == null ? Json(true) : Json($"Email {email} is already in use.");
        }
        
        [AllowAnonymous]
        [HttpGet]
        [Route("Account/ViewProfile/{id?}")]
        public async Task<IActionResult> ViewProfile(string id)
        {
            ApplicationUser user = await _userManager.FindByIdAsync(id);

            //throw new Exception("Error");
            if (user == null)
            {
                _logger.LogError($"User not found with Id= {id} while getting details. 404 status code thrown.");
                Response.StatusCode = 404;
                return View("~/Views/Error/UserNotFound.cshtml");
            }
            
            UserDetailsViewModel userDetailsViewModel = new UserDetailsViewModel()
            {
                User = user,
                PageTitle = "User Details"
            };

            userDetailsViewModel.Dogs = _dogRepository.GetDogsByParentId(user.Id);

            return View(userDetailsViewModel);
        }
        
        [HttpGet]
        [Route("Account/EditProfile/{id?}")]
        public async Task<IActionResult> EditProfile(string id)
        {
            ApplicationUser user = await _userManager.FindByIdAsync(id);

            if (user == null)
            {
                ViewBag.ErrorMessage = $"User with Id = {id} cannot be found";
                return View("~/Views/Error/NotFound.cshtml");
            }

            EditProfileViewModel model = new EditProfileViewModel
            {
                Id = user.Id,
                Email = user.Email,
                UserName = user.UserName,
                FirstName = user.FirstName,
                LastName = user.LastName,
                FullName = user.FirstName + " " + user.LastName,
                Country = user.Country,
                PhotoPath = user.PhotoPath,
                PhoneNumber = user.PhoneNumber,
                Description = user.Description
            };

            return View(model);
        }
        
        [HttpPost]
        public async Task<IActionResult> EditProfile(EditProfileViewModel model)
        {
            ApplicationUser user = await _userManager.FindByIdAsync(model.Id);

            if (user == null)
            {
                ViewBag.ErrorMessage = $"User with Id = {model.Id} cannot be found";
                return View("~/Views/Error/NotFound.cshtml");
            }

            user.Id = model.Id;
            user.Email = model.Email;
            user.UserName = model.UserName;
            user.FirstName = model.FirstName;
            user.LastName = model.LastName;
            user.FullName = model.FirstName + " " + model.LastName;
            user.Country = model.Country;
            user.PhoneNumber = model.PhoneNumber;
            user.Description = model.Description;
            user.PhotoPath = model.PhotoPath;

            IdentityResult result = await _userManager.UpdateAsync(user);

            if (result.Succeeded)
            {
                user.PhotoPath = Path.Combine("~/Images/UserImages/", model.Id, model.PhotoPath);

                return RedirectToAction("ViewProfile", "Account", new {user.Id});
            }

            foreach (IdentityError error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }

            return View(model);
        }
        
        //private async Task<ApplicationUser> GetCurrentUserAsync() => await _userManager.GetUserAsync(HttpContext.User);

        private string ProcessUploadedPhoto(IFormFile photo, string id)
        {
            if (photo == null) return null;

            DirectoryInfo uploadsFolder = Directory.CreateDirectory(Path.Combine(_webHostEnvironment.WebRootPath, "images/UserImages", id));
            string uniqueFileName = Guid.NewGuid() + "_" + photo.FileName;
            string filePath = Path.Combine(uploadsFolder.FullName, uniqueFileName);
            using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
            {
                photo.CopyTo(fileStream);
            }

            return uniqueFileName;
        }
    }
}