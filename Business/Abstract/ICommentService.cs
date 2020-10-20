using Core.DataResult.Abstract;
using Entities.conc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICommentService
    {
        IDataResult<List<Comments>> getAll();     
        IDataResult<List<Comments>> getAllCommentOfTheUserByUserId(int UserId);       
        IDataResult<Comments> getOneById(int id);
        IResult addOrder(Comments Comment);
        IResult updateOrder(Comments Comment);
        IResult deleteCommentById(int id);
        IResult deleteOrderByEntity(Comments Comment);
    }
}
