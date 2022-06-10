using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetFinder_API.Entities
{
    public class Rasa
    {
        public string Id { get; set; }
        public string Nume { get; set; }
        public string Lifespan { get; set; }
        public string SpecieId { get; set; }
        public virtual Specie Specie { get; set; }
        public virtual ICollection<Pet> Pets { get; set; }


    }
}
