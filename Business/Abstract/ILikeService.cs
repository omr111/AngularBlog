using Core.DataResult.Abstract;
using Entities.conc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Abstract
{
    public interface ILikeService
    {
        List<Likes> getAll();
       
      
        IDataResult<Likes> getOneById(int id);
        IResult addLike(Likes Like);
        IResult updateLike(Likes Like);
        IResult deleteLikeById(int id);
        IResult deleteLikeByEntity(Likes Like);
    }
}
