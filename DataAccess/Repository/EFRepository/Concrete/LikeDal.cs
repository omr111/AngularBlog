using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using Core.dataAccess;

using DataAccess.Repository.EFRepository.Abstract;
using DataAccess.entities;

namespace DataAccess.Repository.EFRepository.Concrete
{
    public class LikeDal : RepositoryBase<Like, AngularBlogContext>, ILikeDal
    {
        
    }
}
