using Business.Abstract;
using Core.DataResult.Abstract;
using DataAccess.Repository.EFRepository.Abstract;
using Entities.conc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ContactManager : IContactService
    {
        IContactDal _ContactDal;
        public ContactManager(IContactDal ContactDal)
        {
            _ContactDal = ContactDal;
        }
        public IResult addContact(Contacts Contact)
        {
            throw new NotImplementedException();
        }

        public IResult deleteAddByEntity(Contacts contact)
        {
            throw new NotImplementedException();
        }

        public IResult deleteContactById(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Contacts>> getAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Contacts>> getAllByAddId(int contactId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Contacts> getOneById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult updateContact(Contacts Contact)
        {
            throw new NotImplementedException();
        }
    }
}
