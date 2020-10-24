using Business.Abstract;
using Business.BusinessAspect;
using Business.Constants.BllMethodMessages;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Exception;
using Core.Aspects.Autofac.Logging;
using Core.Aspects.Autofac.Performance;
using Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;
using Core.DataResult.Abstract;
using Core.DataResult.Concrete;
using DataAccess.Repository.EFRepository.Abstract;
using Entities.conc;
using Entities.Dtos;
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
        public IResult addPost(Posts Post)
        {
            throw new NotImplementedException();
        }
        [CacheRemoveAspect("IPostService.get")]
        public IResult deletePostByEntity(Posts Post)
        {
            throw new NotImplementedException();
        }
        [CacheRemoveAspect("IPostService.get")]
        public IResult deletePostById(int id)
        {
            throw new NotImplementedException();
        }
       // [SecuredOperation("Customer")]  //rol yönetimi   
        //[CacheAspect()]
       // [PerformanceAspect(5)] //Post getirilme işlemi 5 saniyeden fazla sürerse debug'a yazacak
       // [LogAspect(typeof(DatabaseLogger))] //dosyaya loglama yapar
       // [ExceptionLogAspect(typeof(DatabaseLogger))]
        public IQueryable<Posts> getAll()
        {
            return _Post.getAll();
        }

        [CacheAspect()]
        public IQueryable<Posts> getAllByCategoryId(int catId)
        {
            return _Post.getAll(x => x.CategoryId == catId);
        }
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<PostDetailDto> getOneById(int id)
        {
            var result = _Post.getOne(x => x.Id == id);
          
            var post = result.Select(z =>
                    new PostDetailDto
                    {
                        tags = z.PostTag.Where(y => y.PostId == z.Id).Select(tag => new tagDto
                        {
                            Id = tag.TagId,
                            TagName = tag.Tag.TagName

                        }).ToList(),
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
                        author = new AuthorForPostDto()
                        {
                            id = z.UserId.Value,
                            Name = z.User.Name,
                            Surname = z.User.Surname
                        },
                        comments = z.Comments.Where(y => y.PostId == z.Id).Select(com => new CommentDto
                        {
                            Id = com.Id,
                            CommentText = com.CommentText,
                            AddedDate = com.AddedDate,
                            User = new userDto_forComment
                            {
                                Id = z.UserId.Value,
                                Email = z.User.Email,
                                IsActive = z.User.IsActive,
                                Name = z.User.Name,
                                ProfileImgUrl = z.User.ProfileImgUrl,
                                Surname = z.User.Surname,
                                UserName = z.User.UserName

                            }

                        }).ToList()
                    }).FirstOrDefault(x=>x.id==id);
            return new DataSuccessResult<PostDetailDto>(post);
        }
        [CacheRemoveAspect("IPostService.get")]
        public IResult updatePost(Posts Post)
        {
            throw new NotImplementedException();
        }
    }
}
