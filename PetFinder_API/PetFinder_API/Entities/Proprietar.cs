using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetFinder_API.Entities
{
    public class Proprietar
    {
        public string Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public int Varsta { get; set; }
        public string nrTelefon { get; set; }
        public virtual ICollection<Pet> Pets { get; set; }

    }
}
