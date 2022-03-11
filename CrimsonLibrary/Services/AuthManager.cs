using CrimsonLibrary.Data.Models;
using CrimsonLibrary.Data.Models.Dtos;

using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CrimsonLibrary.Services
{
    public class AuthManager : IAuthManager
    {
        private readonly UserManager<ApiUser> _userManager;
        private readonly IConfiguration _configuration;
        private ApiUser _user;

        public AuthManager(UserManager<ApiUser> userManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _configuration = configuration;
        }

        public async Task<string> CreateToken()
        {
            var siginingCreds = GetSigningCredentials();
            var claims = await GetClaims();
            var token = GenerateTokenOptions(siginingCreds, claims);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        private JwtSecurityToken GenerateTokenOptions(SigningCredentials siginingCreds, List<Claim> claims)
        {
            var lifeTime = _configuration["Jwt:Lifetime"];

            var token = new JwtSecurityToken(
                    issuer: _configuration["Jwt:Issuer"],
                    claims: claims,
                    expires: new DateTime().AddMinutes(double.Parse(lifeTime)),
                    signingCredentials: siginingCreds
                    
                ); 
            return token;
        }

        private async Task<List<Claim>> GetClaims()
        {
            var claims = new List<Claim> {
                new Claim(ClaimTypes.Name, _user.UserName)
            };

            var roles = await _userManager.GetRolesAsync(_user);
            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }

            return claims;
        }

        private SigningCredentials GetSigningCredentials()
        {
            var jwtKey = _configuration["jwtKey"];
            var secret = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtKey));
            return new SigningCredentials(secret, SecurityAlgorithms.HmacSha256);
        }

        public async Task<bool> ValidateUser(UserLoginDto userDto)
        {
             _user = await _userManager.FindByNameAsync(userDto.Email);
            return (_user != null && await _userManager.CheckPasswordAsync(_user, userDto.Password ) );
        }
    }
}
