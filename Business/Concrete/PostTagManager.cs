using Business.Abstract;
using Core.DataResult.Abstract;
using DataAccess.Repository.EFRepository.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class PostTagManager : IPostTagService
    {
        IPostTagDal _PostTagDal;
        public PostTagManager(IPostTagDal PostTagDal)
        {
            _PostTagDal = PostTagDal;
        }
        public IResult addPostTag(PostTag PostTag)
        {
            throw new NotImplementedException();
        }

        public IResult deletePostTagByEntity(PostTag PostTag)
        {
            throw new NotImplementedException();
        }

        public IResult deletePostTagById(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<PostTag>> getAll()
        {
            throw new NotImplementedException();
        }

    

        public IDataResult<PostTag> getOneById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult updatePostTag(PostTag PostTag)
        {
            throw new NotImplementedException();
        }
    }
}
