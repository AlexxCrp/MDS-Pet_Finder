﻿using Microsoft.AspNetCore.Mvc;
using PetFinder_API.Managers;
using PetFinder_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetFinder_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private IAuthenticationManager authenticationManager;

        public AuthenticationController(IAuthenticationManager authenticationManager)
        {
            this.authenticationManager = authenticationManager;
        }

        [HttpPost("sign-up")]
        public async Task<IActionResult> SignUp([FromBody] SignupUserModel model)
        {
            try
            {
                await authenticationManager.Signup(model);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest("Something failed");
            }
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginUserModel model)
        {
            try
            {
                var tokens = await authenticationManager.Login(model);

                if (tokens != null)
                    return Ok(tokens);
                else
                {
                    return BadRequest("Something failed");
                }
            }
            catch (Exception ex)
            {
                return BadRequest("Exception caught");
            }
        }
    }
}