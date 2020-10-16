using Core.DataResult.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IContactService
    {
        IDataResult<List<Contact>> getAll();
        IDataResult<List<Contact>> getAllByAddId(int contactId);

        IDataResult<Contact> getOneById(int id);
        IResult addContact(Contact Contact);
        IResult updateContact(Contact Contact);
        IResult deleteContactById(int id);
        IResult deleteAddByEntity(Add Add);
    }
}
