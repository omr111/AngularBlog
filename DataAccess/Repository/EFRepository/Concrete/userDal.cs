using System;
using System.Collections.Generic;
using System.Text;
using Core.dataAccess;
using DataAccess.entities;
using DataAccess.Repository.EFRepository.Abstract;
using Entities.Concrete;
namespace DataAccess.Repository.EFRepository.Concrete
{
    public class  userDal : RepositoryBase<user, AngularBlogContext>, IuserDal
    {
    }
}
