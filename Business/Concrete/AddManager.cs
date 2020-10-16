using Business.Abstract;
using Core.DataResult.Abstract;
using DataAccess.Repository.EFRepository.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class AddManager : IAddService
    {
        IAddDal _addDal;
        public AddManager(IAddDal addDal)
        {
            _addDal = addDal;
        }
        IResult IAddService.addAdd(Add Add)
        {
            throw new NotImplementedException();
        }

        IResult IAddService.deleteAddByEntity(Add Add)
        {
            throw new NotImplementedException();
        }

        IResult IAddService.deleteAddById(int id)
        {
            throw new NotImplementedException();
        }

        IDataResult<List<Add>> IAddService.getAll()
        {
            throw new NotImplementedException();
        }

        IDataResult<List<Add>> IAddService.getAllByAddId(int AddId)
        {
            throw new NotImplementedException();
        }

        IDataResult<Add> IAddService.getOneById(int id)
        {
            throw new NotImplementedException();
        }

        IResult IAddService.updateAdd(Add discouAddntCoupon)
        {
            throw new NotImplementedException();
        }
    }
}
