using PetFinder_API.Entities;
using PetFinder_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetFinder_API.Managers
{
    public interface IPetsManager
    {
        List<Pet> GetPets();
        Pet GetPetById(string id);
        FullPetModel GetFullPetById(string id);
        void Create(PetModel model);
        void Update(PetModel model);
        void Delete(string id);
    }
}
