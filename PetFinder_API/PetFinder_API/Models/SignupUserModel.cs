using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetFinder_API.Models
{
    public class SignupUserModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string RoleId { get; set; }
    }
}
