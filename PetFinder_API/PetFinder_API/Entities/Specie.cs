using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetFinder_API.Entities
{
    public class Specie
    {
        public string Id { get; set; }
        public string Nume { get; set; }
        public virtual ICollection<Rasa> Rase { get; set; }

    }
}
