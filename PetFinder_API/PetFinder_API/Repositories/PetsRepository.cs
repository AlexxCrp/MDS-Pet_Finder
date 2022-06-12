using Microsoft.EntityFrameworkCore;
using PetFinder_API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetFinder_API.Repositories
{
    public class PetsRepository : IPetsRepository
    {

        private WebContext db;
        public PetsRepository(WebContext db)
        {
            this.db = db;
        }
        public void Create(Pet pet)
        {
            db.Pets.Add(pet);
            db.SaveChanges();
        }

        public void Delete(Pet pet)
        {
            db.Pets.Remove(pet);
            db.SaveChanges();
        }

        public IQueryable<Pet> GetPetsWithImages()
        {
            var pets = GetPetsIQueryable().Include(x => x.Imagini);
            return pets;
        }

        public IQueryable<Pet> GetPetsIQueryable()
        {
            var pets = db.Pets;
            return pets;
        }

        public void Update(Pet pet)
        {
            db.Pets.Update(pet);
            db.SaveChanges();
        }

        public IQueryable<Pet> GetPetsWithImagesAndRase()
        {
            var pets = GetPetsWithImages().Include(x => x.Rasa);
            return pets;
        }

        public IQueryable<Pet> GetFullPets()
        {
            var pets = GetPetsWithImagesAndRase().Include(x => x.Proprietar);
            return pets;
        }
    }
}
