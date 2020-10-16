using Business.Abstract;
using Core.DataResult.Abstract;
using DataAccess.Repository.EFRepository.Abstract;
using Entities.Concrete;
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
        public IResult addOrder(Comment Comment)
        {
            throw new NotImplementedException();
        }

        public IResult deleteCommentById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult deleteOrderByEntity(Comment Comment)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Comment>> getAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Comment>> getAllCommentOfTheUserByUserId(int UserId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Comment> getOneById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult updateOrder(Comment Comment)
        {
            throw new NotImplementedException();
        }
    }
}
