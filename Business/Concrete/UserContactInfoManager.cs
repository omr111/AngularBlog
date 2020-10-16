using Business.Abstract;
using Core.DataResult.Abstract;
using DataAccess.Repository.EFRepository.Abstract;
using Entities.Concrete;
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
        public IResult addUserContactInfo(UserContactInfo UserContactInfo)
        {
            throw new NotImplementedException();
        }

        public IResult deleteUserContactInfoByEntity(UserContactInfo UserContactInfo)
        {
            throw new NotImplementedException();
        }

        public IResult deleteUserContactInfoById(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<UserContactInfo>> getAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<UserContactInfo>> getAllByUserId(int userId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<UserContactInfo> getOneById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult updateUserContactInfo(UserContactInfo UserContactInfo)
        {
            throw new NotImplementedException();
        }
    }
}
