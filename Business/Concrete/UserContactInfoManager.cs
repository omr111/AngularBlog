using Business.Abstract;
using Core.DataResult.Abstract;
using DataAccess.Repository.EFRepository.Abstract;
using Entities.conc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserContactInfoManager : IUserContactInfoService
    {
        IUserContactInfoDal _UserContactInfoDal;
        public UserContactInfoManager(IUserContactInfoDal UserContactInfoDal)
        {
            _UserContactInfoDal = UserContactInfoDal;
        }
        public IResult addUserContactInfo(UserContactInfoes UserContactInfo)
        {
            throw new NotImplementedException();
        }

        public IResult deleteUserContactInfoByEntity(UserContactInfoes UserContactInfo)
        {
            throw new NotImplementedException();
        }

        public IResult deleteUserContactInfoById(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<UserContactInfoes>> getAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<UserContactInfoes>> getAllByUserId(int userId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<UserContactInfoes> getOneById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult updateUserContactInfo(UserContactInfoes UserContactInfo)
        {
            throw new NotImplementedException();
        }
    }
}
