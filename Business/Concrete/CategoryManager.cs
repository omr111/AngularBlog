using Business.Abstract;
using Business.Constants.BllMethodMessages;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Logging;
using Core.Aspects.Autofac.Performance;
using Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;
using Core.DataResult.Abstract;
using Core.DataResult.Concrete;
using DataAccess.Repository.EFRepository.Abstract;
using Entities.conc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public IQueryable<Categories> getAll()
        {
            return _categoryDal.getAll();
        }
        public IResult addCategory(Categories category)
        {
            throw new NotImplementedException();
        }

        public IResult deleteCategoryByEntity(Categories category)
        {
            throw new NotImplementedException();
        }

        public IResult deleteCategoryById(int id)
        {
            throw new NotImplementedException();
        }

        [CacheAspect()]
        [PerformanceAspect(5)] //Post getirilme işlemi 5 saniyeden fazla sürerse debug'a yazacak
        [LogAspect(typeof(DatabaseLogger))] //dosyaya loglama yapar    
     

        public IDataResult<List<Categories>> getAllByCategoryId(int catId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Categories> getOneById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult updateCategory(Categories category)
        {
            throw new NotImplementedException();
        }
    }
}
