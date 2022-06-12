using PetFinder_API.Entities;
using PetFinder_API.Models;
using PetFinder_API.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetFinder_API.Managers
{
    public class PetsManager : IPetsManager
    {
        private readonly IPetsRepository petsRepository;
        public PetsManager(IPetsRepository petsRepository)
        {
            this.petsRepository = petsRepository;
        }
        public void Create(PetModel model)
        {
            var newPet = new Pet
            {
                Nume = model.Nume,
                Varsta = model.Varsta,
                Sex = model.Sex,
                Greutate = model.Greutate
            };

            petsRepository.Create(newPet);
        }

        public void Delete(string id)
        {
            var pet = GetPetById(id);
            petsRepository.Delete(pet);
        }

        public FullPetModel GetFullPetById(string id)
        {
            var pet = petsRepository.GetFullPets()
                .Select(x => new FullPetModel
                {
                    Id = x.Id,
                    Nume = x.Nume,
                    Varsta = x.Varsta,
                    Sex = x.Sex,
                    Greutate = x.Greutate,
                    NumeProprietar = x.Proprietar.Nume + x.Proprietar.Prenume,
                    NrTelProprietar = x.Proprietar.nrTelefon,
                    NumeRasa = x.Rasa.Nume,
                    imagini = x.Imagini.Select(y => y.Poza).ToList()
                })
                .FirstOrDefault(x => x.Id == id);
            return pet;
        }

        public Pet GetPetById(string id)
        {
            var pet = petsRepository.GetPetsIQueryable().FirstOrDefault(x => x.Id == id);
            return pet;
        }

        public List<Pet> GetPets()
        {
            var pets = petsRepository.GetPetsIQueryable().ToList();
            return pets;
        }

        public void Update(PetModel model)
        {
            var pet = GetPetById(model.Id);
            pet.Nume = model.Nume;
            pet.Varsta = model.Varsta;
            pet.Sex = model.Sex;
            pet.Greutate = model.Greutate;

            petsRepository.Update(pet);
        }
    }
}
