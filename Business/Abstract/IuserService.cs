using Core.DataResult.Abstract;
using Entities.conc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IuserService
    {
        IDataResult<List<Users>> getAll();
      
        IDataResult<Users> getOneById(int id);
        IDataResult<Users> getOneByUserNameAndPassword(string username,string password);
        IDataResult<Users> getOneByEmailAndPassword(string email, string password);
        IDataResult<Users> getOneByUserName(string username);
        IDataResult<Users> getOneByEmail(string email);
        IResult addUser(Users user);
        IResult updateUser(Users user);
        IResult deleteUserById(int id);
        IResult deleteUserByEntity(Users user);
    }
}
