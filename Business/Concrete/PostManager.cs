using Business.Abstract;
using Business.BusinessAspect;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Logging;
using Core.Aspects.Autofac.Performance;
using Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;
using Core.DataResult.Abstract;
using Core.DataResult.Concrete;
using DataAccess.Repository.EFRepository.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;


namespace Business.Concrete
{
    public class PostManager : IPostService
    {
        IPostDal _Post;
        public PostManager(IPostDal Post)
        {
            _Post = Post;
        }
        
        [CacheRemoveAspect("IPostService.get")]//Post service içindeki methodlardan get ile başlayan methodların cache'lerini sil demek"
        public IResult addPost(Post Post)
        {
            throw new NotImplementedException();
        }
        [CacheRemoveAspect("IPostService.get")]
        public IResult deletePostByEntity(Post Post)
        {
            throw new NotImplementedException();
        }
        [CacheRemoveAspect("IPostService.get")]
        public IResult deletePostById(int id)
        {
            throw new NotImplementedException();
        }
       // [SecuredOperation("Customer")]  //rol yönetimi   
        [CacheAspect()]
        [PerformanceAspect(5)] //Post getirilme işlemi 5 saniyeden fazla sürerse debug'a yazacak
        [LogAspect(typeof(DatabaseLogger))] //dosyaya loglama yapar
        public List<Post> getAll()
        {
            return (_Post.getAll().ToList());
        }

        [CacheAspect()]
        public IQueryable<Post> getAllByCategoryId(int catId)
        {
            throw new NotImplementedException();
        }
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<Post> getOneById(int id)
        {
            return new DataSuccessResult<Post>(_Post.getOne(x => x.Id == id));
        }
        [CacheRemoveAspect("IPostService.get")]
        public IResult updatePost(Post Post)
        {
            throw new NotImplementedException();
        }
    }
}
