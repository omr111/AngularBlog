using Business.Abstract;
using Core.DataResult.Abstract;
using DataAccess.Repository.EFRepository.Abstract;
using Entities.conc;
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
        public IResult addUserMessage(UserMessages UserMessage)
        {
            throw new NotImplementedException();
        }

        public IResult deleteUserMessageByEntity(UserMessages UserMessage)
        {
            throw new NotImplementedException();
        }

        public IResult deleteUserMessageById(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<IQueryable<UserMessages>> getAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<UserMessages>> getAllByPostId(int postId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<UserMessages> getOneById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult updateUserMessage(UserMessages UserMessage)
        {
            throw new NotImplementedException();
        }
    }
}
