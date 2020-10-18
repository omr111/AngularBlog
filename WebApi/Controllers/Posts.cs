using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Posts : ControllerBase
    {
        Business.Abstract.IPostService _Post;
        public Posts(Business.Abstract.IPostService Post)
        {
            _Post = Post;
        }
        [HttpGet("getall")]    
        public ActionResult getAll()
        {
            int pageNo = 1; int pageCount = 5;
            var result = _Post.getAll().ToList();
            

            return Ok(result);
        }
        [HttpGet("getone/{id}")]
        
        public ActionResult getone(int id)
        {
            return Ok(_Post.getOneById(id));
        }
    }
}
