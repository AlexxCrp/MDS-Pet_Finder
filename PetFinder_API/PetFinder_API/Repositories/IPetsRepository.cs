using PetFinder_API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetFinder_API.Repositories
{
    public interface IPetsRepository
    {
        IQueryable<Pet> GetPetsIQueryable();
        IQueryable<Pet> GetPetsWithImages();
        IQueryable<Pet> GetPetsWithImagesAndRase();
        IQueryable<Pet> GetFullPets();
        void Create(Pet pet);
        void Update(Pet pet);
        void Delete(Pet pet);
    }
}
