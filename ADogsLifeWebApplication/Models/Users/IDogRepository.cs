using System;
using System.Collections.Generic;
using System.Linq;

namespace ADogsLifeWebApplication.Models.Users
{
    public interface IDogRepository
    {
        Dog GetDog(Guid id);
        IEnumerable<Dog> GetAllDogs();
        Dog Add(Dog dog);
        Dog Update(Dog dogChange);
        Dog Delete(int id);
        IQueryable<Dog> GetDogsByParentId(string id);
    }
}