using Business.Abstract;
using Core.DataResult.Abstract;
using DataAccess.Repository.EFRepository.Abstract;
using Entities.conc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CommentManager : ICommentService
    {
        ICommentDal _CommentDal;
        public CommentManager(ICommentDal CommentDal)
        {
            _CommentDal = CommentDal;
        }
        public IResult addOrder(Comments Comment)
        {
            throw new NotImplementedException();
        }

        public IResult deleteCommentById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult deleteOrderByEntity(Comments Comment)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Comments>> getAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Comments>> getAllCommentOfTheUserByUserId(int UserId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Comments> getOneById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult updateOrder(Comments Comment)
        {
            throw new NotImplementedException();
        }
    }
}
