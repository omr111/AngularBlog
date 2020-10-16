using Business.Abstract;
using Core.DataResult.Abstract;
using Core.DataResult.Concrete;
using DataAccess.Repository.EFRepository.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class roleManager : IroleService
    {
        IroleDal _role;
        IuserDal _user;
        public roleManager(IroleDal role, IuserDal user)
        {
            _role=role;
            _user = user;
        }

        public IResult addRole(role role)
        {
            throw new NotImplementedException();
        }

        public IResult addRoleToUser(int roleId, int userId)
        {
            var isExistUser = _user.getOne(x => x.Id == userId);
            if (isExistUser == null)
            {
                return new ErrorResult();
            }
            var isExistRole = _role.getOne(x => x.Id == roleId);
            if (isExistRole == null)
            {
                return new ErrorResult();
            }
            var isExistRoleToUser = _role.getOne(x => x.RoleUsers.Any(y => y.RoleId == roleId && y.UserId == userId));
            if (isExistRoleToUser != null)
            {
                return new ErrorResult();
            }
            _role.addRoleToUser(roleId, userId);
            return new SuccessResult();
        }

        public IResult deleteRoleByEntity(role role)
        {
            throw new NotImplementedException();
        }

        public IResult deleteRoleById(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<role>> getAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<role>> getAllByUserId(int userId)
        {
            var result = _role.getAll(x => x.RoleUsers.Any(y => y.UserId == userId)).ToList();
            return new DataSuccessResult<List<role>>(result);
        }

        public IDataResult<role> getOneById(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<role> getOneByName(string roleName)
        {
            throw new NotImplementedException();
        }

        public IResult updateRole(role role)
        {
            throw new NotImplementedException();
        }
    }
}
