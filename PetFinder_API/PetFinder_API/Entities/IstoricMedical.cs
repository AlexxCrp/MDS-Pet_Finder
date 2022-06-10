using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetFinder_API.Entities
{
    public class IstoricMedical

    {
        public string Id { get; set; }
        public string Descriere { get; set; }
        
        public string PetId { get; set; }
        public virtual Pet Pet { get; set; }


    }
}
