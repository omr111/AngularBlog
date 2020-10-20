using Business.Abstract;
using Core.DataResult.Abstract;
using Core.DataResult.Concrete;
using DataAccess.Repository.EFRepository.Abstract;
using Entities.conc;
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

        public IResult addRole(Roles role)
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
            var isExistRoleToUser = _role.getOne(x => x.UserRoles.Any(y => y.RoleId == roleId && y.UserId == userId));
            if (isExistRoleToUser != null)
            {
                return new ErrorResult();
            }
            _role.addRoleToUser(roleId, userId);
            return new SuccessResult();
        }

        public IResult deleteRoleByEntity(Roles role)
        {
            throw new NotImplementedException();
        }

        public IResult deleteRoleById(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Roles>> getAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Roles>> getAllByUserId(int userId)
        {
            var result = _role.getAll(x => x.UserRoles.Any(y => y.UserId == userId)).ToList();
            return new DataSuccessResult<List<Roles>>(result);
        }

        public IDataResult<Roles> getOneById(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Roles> getOneByName(string roleName)
        {
            throw new NotImplementedException();
        }

        public IResult updateRole(Roles role)
        {
            throw new NotImplementedException();
        }
    }
}
