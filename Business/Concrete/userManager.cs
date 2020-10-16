using Business.Abstract;
using Business.Constants.BllMethodMessages;
using Core.DataResult.Abstract;
using Core.DataResult.Concrete;
using DataAccess.Repository.EFRepository.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;

namespace Business.Concrete
{
    public class userManager : IuserService
    {
        IuserDal _user;
        public userManager(IuserDal user)
        {
            _user = user;
        }
        public IResult addUser(user user)
        {
            _user.add(user);
            return new SuccessResult(bllMessages.userAdded,true);
        }

        public IResult deleteUserByEntity(user user)
        {
            _user.delete(user);
            return new SuccessResult(bllMessages.userDeleted, true);
        }

        public IResult deleteUserById(int id)
        {
            _user.delete(getOneById(id).data);
            return new SuccessResult(bllMessages.userDeleted, true);
        }

        public IDataResult<List<user>> getAll()
        {
            List<user> users = _user.getAll().ToList();
            return new DataSuccessResult<List<user>>(users, bllMessages.usersListed);
        }

      

        public IDataResult<user> getOneByEmailAndPassword(string email, string password)
        {
            //hash ve salt kontrol edilerek girilen pass eşit mi diye kontrol edilip çağrılacak.
            // return new DataSuccessResult<user>(_user.getOne(x=>x.userEmail&x.p);, bllMessages.userListed);
            throw new NotImplementedException();
        }

        public IDataResult<user> getOneById(int id)
        {
            user user = _user.getOne(x => x.Id == id);

            if (user != null)
            {
                return new DataSuccessResult<user>(user);
            }
            else
                return new DataErrorResult<user>(user);
      
        }
        public IDataResult<user> getOneByEmail(string email)
        {
            user user = _user.getOne(x => x.Email == email);
      
            if (user != null)
            {
                return new DataSuccessResult<user>(user);
            }
            else
                return new DataErrorResult<user>(user);
        }
        public IDataResult<user> getOneByUserName(string username)
        {
            user user = _user.getOne(x => x.userName == username);
            if (user != null)
            {
                return new DataSuccessResult<user>(user);
            }
            else
                return new DataErrorResult<user>(user);
        }

        public IDataResult<user> getOneByUserNameAndPassword(string username, string password)
        {//hash ve salt kontrol edilerek girilen pass eşit mi diye kontrol edilip çağrılacak.
            throw new NotImplementedException();
        }

        public IResult updateUser(user user)
        {
            _user.update(user);
            return new SuccessResult(bllMessages.userUpdated, true);
        }
    }
}
