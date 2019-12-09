using System.Linq;
using ADogsLifeWebApplication.Models.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ADogsLifeWebApplication.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly ILogger<HomeController> _logger;

        public HomeController(UserManager<ApplicationUser> userManager, IWebHostEnvironment webHostEnvironment, ILogger<HomeController> logger)
        {
            _userManager = userManager;
            _userManager = userManager;
            _webHostEnvironment = webHostEnvironment;
            _logger = logger;
        }

        [AllowAnonymous]
        [HttpGet]
        public ViewResult Landing()
        {
            return User.Identity.IsAuthenticated ? View("Index") : View();
        }
        
        [AllowAnonymous]
        public ViewResult Index()
        {
            IQueryable<ApplicationUser> model = _userManager.Users;
            return View(model);
        }

//        [AllowAnonymous]
//        public async Task<IActionResult> Details(string id)
//        {
//            //throw new Exception("Error");
//            if (id != null)
//            {
//                ApplicationUser user = await _userManager.FindByIdAsync(id);
//
//                HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
//                {
//                    User = user,
//                    PageTitle = "User Details"
//                };
//
//                return View(homeDetailsViewModel);
//            }
//            
//            _logger.LogError($"User not found with Id= {id} while getting details. 404 status code thrown.");
//            Response.StatusCode = 404;
//            return View("UserNotFound");
//        }
//
//        [HttpGet]
//        public ViewResult Create()
//        {
//            return View();
//        }

//        [HttpGet]
//        public async Task<IActionResult> Edit(string id)
//        {
//            ApplicationUser user = await _userManager.FindByIdAsync(id);
//            UserEditViewModel userEditViewModel = new UserEditViewModel
//            {
//                FirstName = user.FirstName,
//                LastName = user.LastName,
//                PhoneNumber = user.PhoneNumber,
//                Country = user.Country,
//                ExistingPhotoPath = user.PhotoPath
//            };
//            return View(userEditViewModel);
//        }
//
//        [HttpPost]
//        public IActionResult Edit(UserEditViewModel model)
//        {
//            if (!ModelState.IsValid) return View();
//
//            User user = _userRepository.GetUser(model.Id);
//            user.FirstName = model.FirstName;
//            user.LastName = model.LastName;
//            user.Country = model.Country;
//            user.PhoneNumber = model.PhoneNumber;
//
//            if (model.Photo != null) //If a new image was selected, replace it.
//            {
//                if (model.ExistingPhotoPath != null) //Deletes existing photo
//                {
//                    string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "images", model.ExistingPhotoPath);
//                    System.IO.File.Delete(filePath);
//                }
//                user.PhotoPath = ProcessUploadedPhoto(model);
//            }
//
//            _logger.LogInformation($"User {user.FirstName} {user.LastName} with Id = {user.Id} was updated");
//            _userRepository.Update(user);
//            return RedirectToAction("Index");
//        }
    }
}
