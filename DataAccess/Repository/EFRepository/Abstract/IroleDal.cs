using System;
using System.Collections.Generic;
using System.Text;
using Core.dataAccess;
using Entities.Concrete;
namespace DataAccess.Repository.EFRepository.Abstract
{
    public interface IroleDal : IRepositoryBase<role>
    {
         void addRoleToUser(int roleId, int userId);
        object getAllByUserId(int id);
    }
}
