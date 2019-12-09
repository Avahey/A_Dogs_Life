using System;
using System.Collections.Generic;
using System.Linq;
using ADogsLifeWebApplication.Models.Users;

namespace ADogsLifeWebApplication.Models
{
    public class SqlDogRepository : IDogRepository
    {
        private readonly AppDbContext _context;

        public SqlDogRepository(AppDbContext context)
        {
            this._context = context;
        }

        public Dog Add(Dog dog)
        {
            _context.Dogs.Add(dog);
            _context.SaveChanges();
            return dog;
        }

        public Dog Delete(int id)
        {
            Dog dog = _context.Dogs.Find(id);
            if (dog == null) return null;
            _context.Dogs.Remove(dog);
            _context.SaveChanges();
            return dog;
        }

        public IQueryable<Dog> GetDogsByParentId(string id)
        {
            return _context.Dogs.Where(d => d.IdParent == id);
        }
        
        public Dog GetDog(Guid id)
        {
            return _context.Dogs.Find(id);
        }

        public IEnumerable<Dog> GetAllDogs()
        {
            return _context.Dogs;
        }
        
        public Dog Update(Dog dogChanges)
        {
            var employee = _context.Dogs.Attach(dogChanges);
            employee.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return dogChanges;
        }
    }
}