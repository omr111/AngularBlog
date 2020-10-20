using Business.Abstract;
using Core.DataResult.Abstract;
using DataAccess.Repository.EFRepository.Abstract;
using Entities.conc;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public List<Tags> getAll()
        {
            throw new NotImplementedException();
        }

        public List<Tags> getAllByPostId(int PostId)
        {
            List<Tags> tags= _TagDal.getAll(x => x.PostTag.Any(y => y.PostId == PostId)).ToList();
            return tags;
        }

        public IResult addTag(Tags Tag)
        {
            throw new NotImplementedException();
        }

        public IResult deleteTagByEntity(Tags Tag)
        {
            throw new NotImplementedException();
        }

        public IResult deleteTagById(int id)
        {
            throw new NotImplementedException();
        }

      
        public IDataResult<Tags> getOneById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult updateTag(Tags Tag)
        {
            throw new NotImplementedException();
        }
    }
}
