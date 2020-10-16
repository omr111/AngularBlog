using Core.DataResult.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ITagService
    {
        IDataResult<List<Tag>> getAll();
        IDataResult<List<Tag>> getAllByPostId(int PostId);
       
        IDataResult<Tag> getOneById(int id);
        IResult addTag(Tag Tag);
        IResult updateTag(Tag Tag);
        IResult deleteTagById(int id);
        IResult deleteTagByEntity(Tag Tag);

    }
}
