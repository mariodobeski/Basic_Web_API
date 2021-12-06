using Basic_Web_API.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basic_Web_API.Repository.Repository.Interface
{
    public interface IContactRepository
    {
        int CreateContact(Contact contact);
        void UpdateContac(Company company);
        void DeleteContact(int ContactId);

        IEnumerable<Contact> GetAllContacts(Contact contact);
        IEnumerable<Contact> GetContactsWithCompanyAndCountry(Contact contact);
        IEnumerable<Contact> GetFilterContact(int CountryId, int CompanyId);
    }
}
