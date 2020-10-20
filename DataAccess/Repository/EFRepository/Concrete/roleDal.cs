using System;
using System.Collections.Generic;
using System.Text;
using Core.dataAccess;
using DataAccess.entities;
using DataAccess.Repository.EFRepository.Abstract;
using Entities.conc;

namespace DataAccess.Repository.EFRepository.Concrete
{
    public class  roleDal : RepositoryBase<Roles, AngularBlogContext>, IroleDal
    {
        public void addRoleToUser( int roleId,int userId)
        {
            using (var ctx=new AngularBlogContext())
            {
                ctx.UserRoles.Add(new Entities.conc.UserRoles { RoleId = roleId, UserId = userId });
                ctx.SaveChanges();
            }
        }

        public object getAllByUserId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
