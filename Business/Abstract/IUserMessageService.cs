using Core.DataResult.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Abstract
{
    public interface IUserMessageService
    {
        IDataResult<IQueryable<UserMessage>> getAll();
        IDataResult<List<UserMessage>> getAllByPostId(int postId);
       
        IDataResult<UserMessage> getOneById(int id);
        IResult addUserMessage(UserMessage UserMessage);
        IResult updateUserMessage(UserMessage UserMessage);
        IResult deleteUserMessageById(int id);
        IResult deleteUserMessageByEntity(UserMessage UserMessage);

    }
}
