using Core.DataResult.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface ICategoryService
    {
        IDataResult<List<Category>> getAll();
        IDataResult<List<Category>> getAllByCategoryId(int catId);
    
        IDataResult<Category> getOneById(int id);
        IResult addCategory(Category category);
        IResult updateCategory(Category category);
        IResult deleteCategoryById(int id);
        IResult deleteCategoryByEntity(Category category);
    }
}
