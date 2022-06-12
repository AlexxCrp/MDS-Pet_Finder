using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetFinder_API.Entities
{
    public class Imagine
    {
        public string Id { get; set; }
        public string PetId { get; set; }
        public virtual Pet Pet { get; set; }
        public byte[] Poza { get; set; }
    }
}
