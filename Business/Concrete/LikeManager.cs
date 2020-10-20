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
    public class LikeManager : ILikeService
    {
        ILikeDal _LikeDal;
        public LikeManager(ILikeDal LikeDal)
        {
            _LikeDal = LikeDal;
        }
        public IResult addLike(Likes Like)
        {
            throw new NotImplementedException();
        }

        public IResult deleteLikeByEntity(Likes Like)
        {
            throw new NotImplementedException();
        }

        public IResult deleteLikeById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Likes> getAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Likes> getOneById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult updateLike(Likes Like)
        {
            throw new NotImplementedException();
        }
    }
}
