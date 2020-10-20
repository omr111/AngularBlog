using Core.DataResult.Abstract;
using Entities.conc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserContactInfoService
    {
        IDataResult<List<UserContactInfoes>> getAll();
        IDataResult<List<UserContactInfoes>> getAllByUserId(int userId);
       
        IDataResult<UserContactInfoes> getOneById(int id);
        IResult addUserContactInfo(UserContactInfoes UserContactInfo);
        IResult updateUserContactInfo(UserContactInfoes UserContactInfo);
        IResult deleteUserContactInfoById(int id);
        IResult deleteUserContactInfoByEntity(UserContactInfoes UserContactInfo);

    }
}
