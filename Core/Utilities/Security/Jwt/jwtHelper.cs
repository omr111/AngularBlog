using Core.Extensions;
using Entities.conc;

using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace Core.Utilities.Security.Jwt
{
    public class jwtHelper : ITokenHelper
    {
        IConfiguration _configuration;
        tokenOptions _tokenOption;
        public jwtHelper(IConfiguration configuration)
        {
            _configuration = configuration;
            _tokenOption = _configuration.GetSection("TokenOptions").Get<tokenOptions>();
        }

        public AccessToken CreateToken(Users user, List<Roles> userRoles)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_tokenOption.securityKey));
            var singingCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);
            var jwt = CreateJwtSecurityToken(_tokenOption, user, singingCredentials, userRoles);
            var JwtSecurityTokenHandler = new JwtSecurityTokenHandler();
            var token = JwtSecurityTokenHandler.WriteToken(jwt);
            return new AccessToken
            {
                token = token,
                expireDate = DateTime.Now.AddMinutes(_tokenOption.accessTokenExpiration)
            };

        }
        public JwtSecurityToken CreateJwtSecurityToken(tokenOptions tokenOptions, Users user,
            SigningCredentials SigningCredentials, List<Roles> userRoles)
        {
            var jwt = new JwtSecurityToken(
                issuer: tokenOptions.Issuer,
                audience: tokenOptions.Audience,
                expires: DateTime.Now.AddMinutes(tokenOptions.accessTokenExpiration),
                notBefore: DateTime.Now,
                claims: setClaimsForUser(user, userRoles),
                signingCredentials: SigningCredentials
                );
            return jwt;
        }

        public IEnumerable<Claim> setClaimsForUser(Users user, List<Roles> userRoles)
        {
            var claims = new List<Claim>();
            claims.addIdentifierId(user.Id);
            claims.addEmail(user.Email);
            claims.addNameSurname(user.Name, user.Surname);
            claims.addRole(userRoles.Select(x => x.Name).ToArray());
            return claims;
        }
    }
}
