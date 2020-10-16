using Core.DataResult.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Abstract
{
    public interface ILikeService
    {
        IDataResult<IQueryable<Like>> getAll();
       
      
        IDataResult<Like> getOneById(int id);
        IResult addLike(Like Like);
        IResult updateLike(Like Like);
        IResult deleteLikeById(int id);
        IResult deleteLikeByEntity(Like Like);
    }
}
