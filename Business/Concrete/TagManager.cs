using Business.Abstract;
using Core.DataResult.Abstract;
using DataAccess.Repository.EFRepository.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class TagManager : ITagService
    {
        ITagDal _TagDal;
        public TagManager(ITagDal TagDal)
        {
            _TagDal = TagDal;
        }
        public IResult addTag(Tag Tag)
        {
            throw new NotImplementedException();
        }

        public IResult deleteTagByEntity(Tag Tag)
        {
            throw new NotImplementedException();
        }

        public IResult deleteTagById(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Tag>> getAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Tag>> getAllByPostId(int PostId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Tag> getOneById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult updateTag(Tag Tag)
        {
            throw new NotImplementedException();
        }
    }
}
