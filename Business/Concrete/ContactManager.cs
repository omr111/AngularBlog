using Business.Abstract;
using Core.DataResult.Abstract;
using DataAccess.Repository.EFRepository.Abstract;
using Entities.Concrete;
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
        public IResult addContact(Contact Contact)
        {
            throw new NotImplementedException();
        }

        public IResult deleteAddByEntity(Add Add)
        {
            throw new NotImplementedException();
        }

        public IResult deleteContactById(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Contact>> getAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Contact>> getAllByAddId(int contactId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Contact> getOneById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult updateContact(Contact Contact)
        {
            throw new NotImplementedException();
        }
    }
}
