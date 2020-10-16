using Core.DataResult.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IAddService
    {
        IDataResult<List<Add>> getAll();
        IDataResult<List<Add>> getAllByAddId(int AddId);
       
        IDataResult<Add> getOneById(int id);
        IResult addAdd(Add Add);
        IResult updateAdd(Add Add);
        IResult deleteAddById(int id);
        IResult deleteAddByEntity(Add Add);

    }
}
