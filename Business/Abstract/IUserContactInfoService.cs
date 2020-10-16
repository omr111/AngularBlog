using Core.DataResult.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserContactInfoService
    {
        IDataResult<List<UserContactInfo>> getAll();
        IDataResult<List<UserContactInfo>> getAllByUserId(int userId);
       
        IDataResult<UserContactInfo> getOneById(int id);
        IResult addUserContactInfo(UserContactInfo UserContactInfo);
        IResult updateUserContactInfo(UserContactInfo UserContactInfo);
        IResult deleteUserContactInfoById(int id);
        IResult deleteUserContactInfoByEntity(UserContactInfo UserContactInfo);

    }
}
