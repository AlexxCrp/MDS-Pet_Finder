using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using PetFinder_API.Entities;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace PetFinder_API.Managers
{
    public class TokenManager : ITokenManager
    {
        private readonly IConfiguration configuration;
        private readonly UserManager<User> userManager;

        public TokenManager(IConfiguration configuration, UserManager<User> userManager)
        {
            this.userManager = userManager;
            this.configuration = configuration;
        }

        public async Task<string> CreateToken(User user)
        {
            var roles = await userManager.GetRolesAsync(user);
            var claims = new List<Claim>();

            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }

            //var secretKey = configuration.GetSection("Jwt").GetSection("SecretKey").Get<string>();

            var secretKey = "cheie secreta a mortii"; //nu merge linia de cod de mai sus, incercam asa (stiu ca e o mizerie)

            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(secretKey));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var tokenDescription = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddHours(2),
                SigningCredentials = creds
            };

            var tokenHandler = new JwtSecurityTokenHandler();

            var token = tokenHandler.CreateToken(tokenDescription);

            return tokenHandler.WriteToken(token);

        }
    }
}
