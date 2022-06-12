using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetFinder_API.Models
{
    public class PetModel
    {
        public string Id { get; set; }
        public string Nume { get; set; }
        public string Varsta { get; set; }
        public string Sex { get; set; }
        public string Greutate { get; set; }
        //public string NumeProprietar { get; set; }
        //public string NrTelProprietar { get; set; }
        //public string NumeRasa { get; set; }

    }
}
