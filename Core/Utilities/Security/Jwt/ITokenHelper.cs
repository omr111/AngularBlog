using Entities.conc;

using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Core.Utilities.Security.Jwt
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(Users user,List<Roles> userRoles);
        JwtSecurityToken CreateJwtSecurityToken(tokenOptions tokenOptions, Users user, SigningCredentials SigningCredentials, List<Roles> userRoles);
        IEnumerable<Claim> setClaimsForUser(Users user, List<Roles> userRoles);

    }
}
