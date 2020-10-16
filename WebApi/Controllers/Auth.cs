using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Auth : ControllerBase
    {
        IAuthBll _aut;
        IuserService _user;
        public Auth(IAuthBll aut,IuserService user)
        {
            _aut = aut;
            _user = user;
        }
        [HttpPost("login")]
        public ActionResult login(loginDto loginDto)
        {
            var isLogin = _aut.login(loginDto);
            if (!isLogin.success)
            {
                return BadRequest(isLogin.message);
            }
            var token = _aut.createAccessToken(isLogin.data);
            if (token.success)
            {
                return Ok(token.data);
            }
            return BadRequest(token.message);

        }
        [HttpPost("register")]
        public ActionResult register(registerDto register)
        {
            var isExistUser = _user.getOneByEmail(register.userEmail);
            if (isExistUser.success)
            {
                return BadRequest(isExistUser.message);
            }
            var registerResult = _aut.register(register);
            if (!registerResult.success)
            {
                return BadRequest(registerResult.message);
            }
            return Ok(registerResult.message);
        }
    }
}
