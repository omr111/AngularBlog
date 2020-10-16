using Microsoft.IdentityModel.JsonWebTokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Claims;
using System.Text;

namespace Core.Extensions
{
  public  static class claimExtentions
    {
        public static void addEmail(this ICollection<Claim> claims,string email)
        {
            claims.Add(new Claim(JwtRegisteredClaimNames.Email, email));
        }
        public static void addIdentifierId(this ICollection<Claim> claims, int id)
        {
            claims.Add(new Claim(ClaimTypes.NameIdentifier, id.ToString()));
        }
        public static void addNameSurname(this ICollection<Claim> claims, string name,string surname)
        {
            claims.Add(new Claim(ClaimTypes.Name, $"{name} {surname }"));
        }
        public static void addRole(this ICollection<Claim> claims ,string[] roleName)
        {
            roleName.ToList().ForEach(role=>claims.Add(new Claim(ClaimTypes.Role,role )));
            
        }
    }
}
