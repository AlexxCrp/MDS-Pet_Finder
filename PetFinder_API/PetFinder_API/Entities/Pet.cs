using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetFinder_API.Entities
{
    public class Pet
    {
        public string Id { get; set; }
        public string Nume { get; set; }
        public string Varsta { get; set; }
        public string Sex { get; set; }
        public string Greutate { get; set; }
        public string Poza { get; set; }
        public string ProprietarId { get; set; }
        public virtual Proprietar Proprietar { get; set; }
        public string RasaId { get; set; }
        public virtual Rasa Rasa { get; set; }
        public virtual IstoricMedical IstoricMedical { get; set; }

    }
}
