using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace ADogsLifeWebApplication.ViewModels.Account
{
    public class RegisterDogViewModel
    {
        public Guid Id { get; set; }
        
        [Required]
        [Display(Name = "Doggo's Name:")]
        [RegularExpression(@"^[\w'\-,.]*[^_!¡?÷?¿\/\\+=@#$%ˆ&*(){}|~<>;:[\]]*$")]
        [MaxLength(15, ErrorMessage = "First name cannot exceed 15 characters")]
        public string FirstName { get; set; }
        
        [Display(Name = "Middle Name:")]
        [RegularExpression(@"^[\w'\-,.]*[^_!¡?÷?¿\/\\+=@#$%ˆ&*(){}|~<>;:[\]]*$")]
        [MaxLength(15, ErrorMessage = "Last name cannot exceed 15 characters")]
        public string MiddleName { get; set; }

        public string FullName { get; set; }
        
        [Required]
        [Display(Name = "Breed:")]
        public string Breed { get; set; }

        [Display(Name = "Favorite Toy:")]
        public string FavoriteToy { get; set; }

        [Display(Name = "Description:")]
        public string Description { get; set; }
        
        [Display(Name = "Photo:")]
        public IFormFile Photo { get; set; }

        public string IdParent { get; set; }
    }
}