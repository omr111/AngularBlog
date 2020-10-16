using Core.DataResult.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IuserService
    {
        IDataResult<List<user>> getAll();
      
        IDataResult<user> getOneById(int id);
        IDataResult<user> getOneByUserNameAndPassword(string username,string password);
        IDataResult<user> getOneByEmailAndPassword(string email, string password);
        IDataResult<user> getOneByUserName(string username);
        IDataResult<user> getOneByEmail(string email);
        IResult addUser(user user);
        IResult updateUser(user user);
        IResult deleteUserById(int id);
        IResult deleteUserByEntity(user user);
    }
}
