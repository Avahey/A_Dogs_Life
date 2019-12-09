using System.ComponentModel.DataAnnotations;
using ADogsLifeWebApplication.Models.Users;
using Microsoft.AspNetCore.Mvc;

namespace ADogsLifeWebApplication.ViewModels.Account
{
    public class EditProfileViewModel
    {
        public string Id { get; set; }

        [Required]
        public string UserName { get; set; }

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
        public Countries? Country { get; set; }
        [Display(Name = "Upload New Profile Picture:")]
        public string PhotoPath { get; set; }
        
        [Display(Name = "About Me:")]
        public string Description { get; set; }
        public string FullName { get; set; }
        
        [RegularExpression(@"^([0-9]( |-)?)?(\(?[0-9]{3}\)?|[0-9]{3})( |-)?([0-9]{3}( |-)?[0-9]{4}|[a-zA-Z0-9]{7})$", ErrorMessage = "Invalid phone number format")]
        [Display(Name = "Phone Number:")]
        public string PhoneNumber { get; set; }
    }
}