using Core.DataResult.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IroleService
    {
        IDataResult<List<role>> getAll();
        IDataResult<List<role>> getAllByUserId(int userId);
        IDataResult<role> getOneById(int id);
        IDataResult<role> getOneByName(string roleName);
        IResult addRole(role role);
        IResult updateRole(role role);
        IResult deleteRoleById(int id);
        IResult deleteRoleByEntity(role role);
        IResult addRoleToUser(int roleId, int userId);
    }
}
