using Business.Abstract;
using Business.Constants.BllMethodMessages;
using Core.DataResult.Abstract;
using Core.DataResult.Concrete;
using DataAccess.Repository.EFRepository.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CategoryBll : ICategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryBll(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        IResult ICategoryService.addCategory(Category category)
        {
            throw new NotImplementedException();
        }

        IResult ICategoryService.deleteCategoryByEntity(Category category)
        {
            throw new NotImplementedException();
        }

        IResult ICategoryService.deleteCategoryById(int id)
        {
            throw new NotImplementedException();
        }

        IDataResult<List<Category>> ICategoryService.getAll()
        {
            throw new NotImplementedException();
        }

        IDataResult<List<Category>> ICategoryService.getAllByCategoryId(int catId)
        {
            throw new NotImplementedException();
        }

        IDataResult<Category> ICategoryService.getOneById(int id)
        {
            throw new NotImplementedException();
        }

        IResult ICategoryService.updateCategory(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
