using Core.DataResult.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;


namespace Business.Abstract
{
    public interface   IPostService
    {
        IQueryable<Post> getAll();
        IQueryable<Post> getAllByCategoryId(int catId);
        IDataResult<Post> getOneById(int id);
        IResult addPost(Post Post);
        IResult updatePost(Post Post);
        IResult deletePostById(int id);
        IResult deletePostByEntity(Post Post);
    }
}
