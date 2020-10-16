using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors.Autofac;
using Core.Utilities.Security.Jwt;
using DataAccess.Repository.EFRepository.Abstract;
using DataAccess.Repository.EFRepository.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependecyResolvers.AutoFac
{
   public class autofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<AddManager>().As<IAddService>();
            builder.RegisterType<AddDal>().As<IAddDal>();

            builder.RegisterType<CategoryBll>().As<ICategoryService>();
            builder.RegisterType<CategoryDal>().As<ICategoryDal>();

            builder.RegisterType<CommentManager>().As<ICommentService>();
            builder.RegisterType<CommentDal>().As<ICommentDal>();

            builder.RegisterType<ContactManager>().As<IContactService>();
            builder.RegisterType<ContactDal>().As<IContactDal>();

            builder.RegisterType<LikeManager>().As<ILikeService>();
            builder.RegisterType<LikeDal>().As<ILikeDal>();

            builder.RegisterType<PostTagManager>().As<IPostTagService>();
            builder.RegisterType<IPostTagDal>().As<IPostTagDal>();

            builder.RegisterType<roleManager>().As<IroleService>();
            builder.RegisterType<roleDal>().As<IroleDal>();

            builder.RegisterType<PostManager>().As<IPostService>();
            builder.RegisterType<PostDal>().As<IPostDal>();

            builder.RegisterType<userManager>().As<IuserService>();
            builder.RegisterType<userDal>().As<IuserDal>();

            builder.RegisterType<UserContactInfoManager>().As<IUserContactInfoService>();
            builder.RegisterType<UserContactInfoDal>().As<IUserContactInfoDal>();

            builder.RegisterType<UserMessageManager>().As<IUserMessageService>();
            builder.RegisterType<UserMessageDal>().As<IUserMessageDal>();

 
            
            builder.RegisterType<AuthManager>().As<IAuthBll>();
            
            builder.RegisterType<jwtHelper>().As<ITokenHelper>();
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions() {
                    Selector=new AspectInterceptorSelector()
                
                }).SingleInstance();

        }
    }
}
