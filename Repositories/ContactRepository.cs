using Basic_Web_API.Data.Entities;
using Basic_Web_API.Repository.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basic_Web_API.Repository
{
    public class ContactRepository : IContactRepository
    {
        public int CreateContact(Contact contact)
        {
            throw new NotImplementedException();
        }

        public void DeleteContact(int ContactId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Contact> GetAllContacts(Contact contact)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Contact> GetContactsWithCompanyAndCountry(Contact contact)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Contact> GetFilterContact(int CountryId, int CompanyId)
        {
            throw new NotImplementedException();
        }

        public void UpdateContac(Company company)
        {
            throw new NotImplementedException();
        }
    }
}
