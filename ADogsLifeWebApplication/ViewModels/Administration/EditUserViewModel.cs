using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ADogsLifeWebApplication.Models.Users;

namespace ADogsLifeWebApplication.ViewModels.Administration
{
    public class EditUserViewModel
    {
        public EditUserViewModel()
        {
            Claims = new List<string>();
            Roles = new List<string>();
        }

        public string Id { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Countries? Country { get; set; }
        public string PhotoPath { get; set; }
        public string Description { get; set; }
        public string FullName { get; set; }

        public List<string> Claims { get; set; }

        public IList<string> Roles { get; set; }
    }
}