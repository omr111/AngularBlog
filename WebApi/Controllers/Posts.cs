using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.conc;
using Entities.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Posts : ControllerBase
    {
        IPostService _Post;

        public Posts(IPostService Post)
        {
            _Post = Post;

        }
        [HttpGet("{pageCount}/{pageNumber}")]
        public ActionResult getAll(int pageCount = 10, int pageNumber = 1)
        {


            var result = _Post.getAll().Include(a => a.Category)
                .Skip(pageCount * (pageNumber - 1)).Take(pageCount).OrderByDescending(x => x.ReleaseDate);


            result.Select(z =>
                new postDto
                {

                    id = z.Id,
                    BackgroundImgUrl = z.BackgroundImgUrl,
                    commentCount = z.Comments.Count,
                    Description = z.Description,
                    IsActive = z.IsActive,
                    likeCount = z.Likes.Count,
                    ReadCount = z.ReadCount,
                    ReleaseDate = z.ReleaseDate,
                    Text = z.Text,
                    Title = z.Title,

                    category = new CategoryDto
                    {
                        categoryName = z.Category.CategoryName,
                        id = z.CategoryId,
                        parentId = z.Category.ParentId
                    },

                }).ToList();
            var model = new
            {
                postList = result,
                totalPostCount = result.Count()
            };

            return Ok(model);
        }
        [HttpGet("{id}")]


        public ActionResult getone(int id)
        {
            //var result = _Post.getOneById(id).data.Include(a => a.Category).Include(b => b.User).Include(c => c.Likes)
            //   .Include(d => d.Comments).Include(e => e.PostTag).ThenInclude(f => f.Tag)
            //   ;

            //result.Select(z =>
            //    new PostDetailDto
            //    {
            //        tags = z.PostTag.Where(y => y.PostId == z.Id).Select(c => new tagDto
            //        {
            //            Id = c.TagId,
            //            TagName = c.Tag.TagName

            //        }).ToList(),
            //        id = z.Id,
            //        BackgroundImgUrl = z.BackgroundImgUrl,
            //        commentCount = z.Comments.Count,
            //        Description = z.Description,
            //        IsActive = z.IsActive,
            //        likeCount = z.Likes.Count,
            //        ReadCount = z.ReadCount,
            //        ReleaseDate = z.ReleaseDate,
            //        Text = z.Text,
            //        Title = z.Title,
            //        category = new CategoryDto
            //        {
            //            categoryName = z.Category.CategoryName,
            //            id = z.CategoryId,
            //            parentId = z.Category.ParentId
            //        },
            //        author = new AuthorForPostDto()
            //        {
            //            id = z.UserId.Value,
            //            Name = z.User.Name,
            //            Surname = z.User.Surname
            //        }
            //    }).ToList();
            return Ok(_Post.getOneById(id));
        }
    }
}
