using Microsoft.AspNetCore.Identity;

namespace ADogsLifeWebApplication.Models.Users
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Countries? Country { get; set; }
        public string PhotoPath { get; set; }
        public string Description { get; set; }
        public string FullName { get; set; }
    }
}