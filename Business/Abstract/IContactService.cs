using Core.DataResult.Abstract;
using Entities.conc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IContactService
    {
        IDataResult<List<Contacts>> getAll();
        IDataResult<List<Contacts>> getAllByAddId(int contactId);

        IDataResult<Contacts> getOneById(int id);
        IResult addContact(Contacts Contact);
        IResult updateContact(Contacts Contact);
        IResult deleteContactById(int id);
        IResult deleteAddByEntity(Contacts Add);
    }
}
