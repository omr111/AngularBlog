using Core.DataResult.Abstract;
using Entities.conc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Abstract
{
    public interface IUserMessageService
    {
        IDataResult<IQueryable<UserMessages>> getAll();
        IDataResult<List<UserMessages>> getAllByPostId(int postId);
       
        IDataResult<UserMessages> getOneById(int id);
        IResult addUserMessage(UserMessages UserMessage);
        IResult updateUserMessage(UserMessages UserMessage);
        IResult deleteUserMessageById(int id);
        IResult deleteUserMessageByEntity(UserMessages UserMessage);

    }
}
