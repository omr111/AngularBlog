using Business.Abstract;
using Core.DataResult.Abstract;
using DataAccess.Repository.EFRepository.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class UserMessageManager : IUserMessageService
    {
        IUserMessageDal _UserMessageDal;
        public UserMessageManager(IUserMessageDal UserMessageDal)
        {
            _UserMessageDal = UserMessageDal;
        }
        public IResult addUserMessage(UserMessage UserMessage)
        {
            throw new NotImplementedException();
        }

        public IResult deleteUserMessageByEntity(UserMessage UserMessage)
        {
            throw new NotImplementedException();
        }

        public IResult deleteUserMessageById(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<IQueryable<UserMessage>> getAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<UserMessage>> getAllByPostId(int postId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<UserMessage> getOneById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult updateUserMessage(UserMessage UserMessage)
        {
            throw new NotImplementedException();
        }
    }
}
