using Business.Abstract;
using Core.DataResult.Abstract;
using DataAccess.Repository.EFRepository.Abstract;
using Entities.conc;
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

        public IResult addAdd(Adds Add)
        {
            throw new NotImplementedException();
        }

        public IResult deleteAddByEntity(Adds Add)
        {
            throw new NotImplementedException();
        }

        public IResult deleteAddById(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Adds>> getAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Adds>> getAllByAddId(int AddId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Adds> getOneById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult updateAdd(Adds Add)
        {
            throw new NotImplementedException();
        }
    }
}
