using Library.Auth.Common;
using Library.Auth.Models;
using Library.Models;
using Library.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;

namespace Library.Auth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        public IOptions<AuthOptions> authOptions { get; }

        public AuthController(IOptions<AuthOptions> authOptions)
        {
            this.authOptions = authOptions;
        }

        [HttpPost("Login")]
        public IActionResult Login([FromBody] Login request)
        {
            var client = AuthentikateUser(request.Email, request.Password);
            
            if(client != null)
            {
                var token = generateJWT(client);
                return Ok(new { access_token = token });
            }
            return Unauthorized();
        }

        private Client AuthentikateUser(string email, string pass)
        {
            return APIClient.GetRequest<List<Client>>($"api/client")
                .SingleOrDefault(x => x.Email == email && x.Password == pass);
        }

        private string generateJWT(Client client)
        {
            var authParams = authOptions.Value;

            var secretKey = authParams.GetSymmetricSecurityKey();

            var credentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

            var claims = new List<Claim>()
            {
                new Claim(JwtRegisteredClaimNames.Email, client.Email),
                new Claim(JwtRegisteredClaimNames.Sub, client.Id)
            };

            var token = new JwtSecurityToken(
                authParams.ISSUER,
                authParams.AUDIENCE,
                claims,
                expires: DateTime.Now.AddSeconds(authParams.LIFETIME),
                signingCredentials: credentials
                );
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
