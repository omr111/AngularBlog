using Business.Abstract;
using Business.Constants.BllMethodMessages;
using Core.DataResult.Abstract;
using Core.DataResult.Concrete;
using DataAccess.Repository.EFRepository.Abstract;
using Entities.conc;
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
        public IResult updateUser(Users user)
        {
            _user.update(user);
            return new SuccessResult(bllMessages.userUpdated, true);
        }
        public IDataResult<Users> getOneById(int id)
        {
            var user = _user.getOne(x => x.Id == id);

            if (user != null)
            {
                return new DataSuccessResult<Users>(user.First());
            }
            else
                return new DataErrorResult<Users>(user.First());

        }
        public IResult addUser(Users user)
        {
            _user.add(user);
            return new SuccessResult(bllMessages.userAdded,true);
        }

        public IResult deleteUserByEntity(Users user)
        {
            _user.delete(user);
            return new SuccessResult(bllMessages.userDeleted, true);
        }

        public IResult deleteUserById(int id)
        {
            _user.delete(getOneById(id).data);
            return new SuccessResult(bllMessages.userDeleted, true);
        }

        public IDataResult<List<Users>> getAll()
        {
            List<Users> users = _user.getAll().ToList();
            return new DataSuccessResult<List<Users>>(users, bllMessages.usersListed);
        }

      

        public IDataResult<Users> getOneByEmailAndPassword(string email, string password)
        {
            //hash ve salt kontrol edilerek girilen pass eşit mi diye kontrol edilip çağrılacak.
            // return new DataSuccessResult<user>(_user.getOne(x=>x.userEmail&x.p);, bllMessages.userListed);
            throw new NotImplementedException();
        }

       
        public IDataResult<Users> getOneByEmail(string email)
        {
            var user = _user.getOne(x => x.Email == email);
      
            if (user != null)
            {
                return new DataSuccessResult<Users>(user.FirstOrDefault());
            }
            else
                return new DataErrorResult<Users>(user.FirstOrDefault());
        }
        public IDataResult<Users> getOneByUserName(string username)
        {
            var user = _user.getOne(x => x.UserName == username);
            if (user != null)
            {
                return new DataSuccessResult<Users>(user.FirstOrDefault());
            }
            else
                return new DataErrorResult<Users>(user.FirstOrDefault());
        }

        public IDataResult<Users> getOneByUserNameAndPassword(string username, string password)
        {//hash ve salt kontrol edilerek girilen pass eşit mi diye kontrol edilip çağrılacak.
            throw new NotImplementedException();
        }

       
    }
}
