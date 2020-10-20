using Core.DataResult.Abstract;
using Entities.conc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ITagService
    {
        List<Tags> getAll();
        List<Tags> getAllByPostId(int PostId);
       
        IDataResult<Tags> getOneById(int id);
        IResult addTag(Tags Tag);
        IResult updateTag(Tags Tag);
        IResult deleteTagById(int id);
        IResult deleteTagByEntity(Tags Tag);

    }
}
