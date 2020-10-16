using Core.DataResult.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICommentService
    {
        IDataResult<List<Comment>> getAll();     
        IDataResult<List<Comment>> getAllCommentOfTheUserByUserId(int UserId);       
        IDataResult<Comment> getOneById(int id);
        IResult addOrder(Comment Comment);
        IResult updateOrder(Comment Comment);
        IResult deleteCommentById(int id);
        IResult deleteOrderByEntity(Comment Comment);
    }
}
