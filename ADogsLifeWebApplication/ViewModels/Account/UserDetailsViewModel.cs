using System.Linq;
using ADogsLifeWebApplication.Models.Users;

namespace ADogsLifeWebApplication.ViewModels.Account
{
    public class UserDetailsViewModel
    {
        public ApplicationUser User { get; set; }
        public string PageTitle { get; set; }
        public IQueryable<Dog> Dogs { get; set; }
    }
}
