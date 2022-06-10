using PetFinder_API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetFinder_API.Managers
{
    public interface ITokenManager
    {
        Task<string> CreateToken(User user);
    }
}
