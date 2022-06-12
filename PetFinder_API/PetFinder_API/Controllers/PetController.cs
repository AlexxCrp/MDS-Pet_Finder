using Microsoft.AspNetCore.Mvc;
using PetFinder_API.Managers;
using PetFinder_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetFinder_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetController : ControllerBase
    {
        private readonly IPetsManager manager;

        public PetController(IPetsManager petsManager)
        {
            this.manager = petsManager;
        }

        [HttpGet]
        public async Task<IActionResult> GetPets()
        {
            var pets = manager.GetPets();
            return Ok(pets);
        }

        [HttpGet("FullPetById/{id}")]
        public async Task<IActionResult> GetFullPet([FromRoute] string id)
        {
            var pet = manager.GetFullPetById(id);
            return Ok(pet);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] PetModel petModel)
        {
            manager.Create(petModel);

            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] PetModel petModel)
        {
            manager.Update(petModel);

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] string id)
        {
            manager.Delete(id);

            return Ok();
        }
    }
}
