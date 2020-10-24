using Core.DataResult.Abstract;
using Entities.conc;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;


namespace Business.Abstract
{
    public interface   IPostService
    {
        IQueryable<Posts> getAll();
        IQueryable<Posts> getAllByCategoryId(int catId);
        IDataResult<PostDetailDto> getOneById(int id);
        IResult addPost(Posts Post);
        IResult updatePost(Posts Post);
        IResult deletePostById(int id);
        IResult deletePostByEntity(Posts Post);
    }
}
