using System;

namespace ADogsLifeWebApplication.Models.Users
{
    public class Dog
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string Breed { get; set; }
        public string IdParent { get; set; }
        public string FavoriteToy { get; set; }
        public string Description { get; set; }
        public string PhotoPath { get; set; }
    }
}