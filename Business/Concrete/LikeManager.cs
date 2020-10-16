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
    public class LikeManager : ILikeService
    {
        ILikeDal _LikeDal;
        public LikeManager(ILikeDal LikeDal)
        {
            _LikeDal = LikeDal;
        }
        public IResult addLike(Like Like)
        {
            throw new NotImplementedException();
        }

        public IResult deleteLikeByEntity(Like Like)
        {
            throw new NotImplementedException();
        }

        public IResult deleteLikeById(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<IQueryable<Like>> getAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Like> getOneById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult updateLike(Like Like)
        {
            throw new NotImplementedException();
        }
    }
}
