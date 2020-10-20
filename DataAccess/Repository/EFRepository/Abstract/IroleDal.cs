using System;
using System.Collections.Generic;
using System.Text;
using Core.dataAccess;
using Entities.conc;

namespace DataAccess.Repository.EFRepository.Abstract
{
    public interface IroleDal : IRepositoryBase<Roles>
    {
         void addRoleToUser(int roleId, int userId);
        object getAllByUserId(int id);
    }
}
