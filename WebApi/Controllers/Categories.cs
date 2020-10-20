using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Logging;
using Core.Aspects.Autofac.Performance;
using Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;
using Entities.conc;
using Entities.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Categories : ControllerBase
    {
        private ICategoryService _category;
        public Categories(ICategoryService category)
        {
            _category = category;
        }

        [HttpGet]
        public ActionResult getAll()
        {
            var result=  _category.getAll().Select(x=>new CategoryDto
            {
                id=x.Id,
                parentId=x.ParentId,
                categoryName=x.CategoryName,
            }).ToList();
            return Ok(result);
        }
    }
}
