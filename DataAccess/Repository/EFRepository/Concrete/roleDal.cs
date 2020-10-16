using System;
using System.Collections.Generic;
using System.Text;
using Core.dataAccess;
using DataAccess.entities;
using DataAccess.Repository.EFRepository.Abstract;
using Entities.Concrete;
namespace DataAccess.Repository.EFRepository.Concrete
{
    public class  roleDal : RepositoryBase<role, AngularBlogContext>, IroleDal
    {
        public void addRoleToUser( int roleId,int userId)
        {
            using (var ctx=new AngularBlogContext())
            {
                ctx.userRoles.Add(new userRole { RoleId = roleId, UserId = userId });
                ctx.SaveChanges();
            }
        }

        public object getAllByUserId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
