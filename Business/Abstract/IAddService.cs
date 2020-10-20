using Core.DataResult.Abstract;
using Entities.conc;

using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IAddService
    {
        IDataResult<List<Adds>> getAll();
        IDataResult<List<Adds>> getAllByAddId(int AddId);
       
        IDataResult<Adds> getOneById(int id);
        IResult addAdd(Adds Add);
        IResult updateAdd(Adds Add);
        IResult deleteAddById(int id);
        IResult deleteAddByEntity(Adds Add);

    }
}
