using Core.DataResult.Abstract;
using Core.Utilities.Security.Jwt;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IAuthBll
    {
        IResult register(registerDto register);
        IDataResult<user> login(loginDto login);
 
        IDataResult<AccessToken> createAccessToken(user user);
    }
}
