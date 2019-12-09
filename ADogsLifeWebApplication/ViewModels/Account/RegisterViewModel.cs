using System.ComponentModel.DataAnnotations;
using ADogsLifeWebApplication.Models.Users;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ADogsLifeWebApplication.ViewModels.Account
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "Email Address: ")]
        [EmailAddress]
        [Remote(action: "IsEmailInUse", controller: "Account")]
        public string Email { get; set; }
        
        [Required]
        [Display(Name = "First Name:")]
        [RegularExpression(@"^[\w'\-,.]*[^_!¡?÷?¿\/\\+=@#$%ˆ&*(){}|~<>;:[\]]*$")]
        [MaxLength(15, ErrorMessage = "First name cannot exceed 15 characters")]
        public string FirstName { get; set; }
        
        [Required]
        [Display(Name = "Last Name:")]
        [RegularExpression(@"^[\w'\-,.]*[^_!¡?÷?¿\/\\+=@#$%ˆ&*(){}|~<>;:[\]]*$")]
        [MaxLength(15, ErrorMessage = "Last name cannot exceed 15 characters")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Password: ")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password: ")]
        [Compare("Password",
            ErrorMessage = "Passwords do not match.")]
        public string ConfirmPassword { get; set; }

        [RegularExpression(@"^([0-9]( |-)?)?(\(?[0-9]{3}\)?|[0-9]{3})( |-)?([0-9]{3}( |-)?[0-9]{4}|[a-zA-Z0-9]{7})$", ErrorMessage = "Invalid phone number format")]
        [Display(Name = "Phone Number:")]
        public string PhoneNumber { get; set; }
        
        [Required]
        [Display(Name = "Country:")]
        public Countries? Country { get; set; }
        
        [Display(Name = "Photo:")]
        public IFormFile Photo { get; set; }

        public string Description { get; set; }
    }
}