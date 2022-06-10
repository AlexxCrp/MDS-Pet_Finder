using PetFinder_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetFinder_API.Managers
{
    public interface IAuthenticationManager
    {
        Task Signup(SignupUserModel signupUserModel);
        Task<TokenModel> Login(LoginUserModel loginUserModel);
    }
}
