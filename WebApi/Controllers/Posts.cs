﻿using System;
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
            var result = _Post.getAll().OrderByDescending(x=>x.ReleaseDate);
            int totalCount = result.Count();
            var posts = PostPagingMethod(result, pageCount, pageNumber);
            var model = new
            {   posts = posts,
                totalPostCount = totalCount
            };

            return Ok(model);
        }
        [HttpGet("{categoryId}/{pageCount}/{pageNumber}")]
        public ActionResult getAll(int categoryId, int pageCount = 10, int pageNumber = 1)
        {
            var result = _Post.getAllByCategoryId(categoryId).OrderByDescending(x=>x.ReleaseDate);
            int totalCount = result.Count();
            var posts = PostPagingMethod(result, pageCount, pageNumber);
            var model = new
            {
                posts = posts,
                totalPostCount = totalCount
            };

            return Ok(model);
        }
        [HttpGet("{id}")]
        public ActionResult getone(int id)
        {
            var result = _Post.getOneById(id);


            return Ok(result.data);
        }
        private List<postDto> PostPagingMethod(IQueryable<Entities.conc.Posts> postList, int itemCount, int page)
        {

            var posts = postList.Skip(itemCount * (page - 1)).Take(itemCount).OrderByDescending(x => x.ReleaseDate).Select(z =>
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
            return posts;
        }
        [HttpGet]
        [Route("searchPosts/{searchText}/{perPageItemCount}/{pageNumber}")]
        public ActionResult searchPosts(string searchText,int perPageItemCount=10,int pageNumber=1)
        {
            var foundPosts = _Post.getAllSearchedPosts(searchText).OrderByDescending(x=>x.ReleaseDate);
            int totalCount = foundPosts.Count();
            var posts = PostPagingMethod(foundPosts, perPageItemCount, pageNumber);
            var model = new
            {
                posts = posts,
                totalPostCount = totalCount
            };
            return Ok(model);
        }
        [HttpGet]
        [Route("IncreaseViewedCount/{postId}")]
        public ActionResult IncreaseViewedCount(int postId)
        {
            var post = _Post.getOneByIdWithEntity(postId);
            if (post.success)
            {
                post.data.ReadCount += 1;
                var result=_Post.updatePost(post.data);
                if (result.success)
                {
                    return Ok();
                }
            }
            return BadRequest();
        }
    }
}
