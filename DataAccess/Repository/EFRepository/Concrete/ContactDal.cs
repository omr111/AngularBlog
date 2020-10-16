using Core.dataAccess;
using DataAccess.entities;
using DataAccess.Repository.EFRepository.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repository.EFRepository.Concrete
{
   public class ContactDal:RepositoryBase<Contact,AngularBlogContext>,IContactDal
    {
    }
}
