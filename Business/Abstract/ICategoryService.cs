using Core.DataResult.Abstract;
using Entities.conc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Abstract
{
   public interface ICategoryService
    {
        IQueryable<Categories> getAll();
        IDataResult<List<Categories>> getAllByCategoryId(int catId);
    
        IDataResult<Categories> getOneById(int id);
        IResult addCategory(Categories category);
        IResult updateCategory(Categories category);
        IResult deleteCategoryById(int id);
        IResult deleteCategoryByEntity(Categories category);
    }
}
