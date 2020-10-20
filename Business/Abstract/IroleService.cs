using Core.DataResult.Abstract;
using Entities.conc;

using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IroleService
    {
        IDataResult<List<Roles>> getAll();
        IDataResult<List<Roles>> getAllByUserId(int userId);
        IDataResult<Roles> getOneById(int id);
        IDataResult<Roles> getOneByName(string roleName);
        IResult addRole(Roles role);
        IResult updateRole(Roles role);
        IResult deleteRoleById(int id);
        IResult deleteRoleByEntity(Roles role);
        IResult addRoleToUser(int roleId, int userId);
    }
}
