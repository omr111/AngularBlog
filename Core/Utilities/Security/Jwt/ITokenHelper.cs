using Entities.Concrete;
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
        AccessToken CreateToken(user user,List<role> userRoles);
        JwtSecurityToken CreateJwtSecurityToken(tokenOptions tokenOptions, user user, SigningCredentials SigningCredentials, List<role> userRoles);
        IEnumerable<Claim> setClaimsForUser(user user, List<role> userRoles);

    }
}
