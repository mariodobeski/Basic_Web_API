using Basic_Web_API.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basic_Web_API.Services.Service.Interfaces
{
    public interface IContactService
    {
        int CreateContact(Contact contact);
        void UpdateContac(Company company);
        void DeleteContact(int ContactId);

        IEnumerable<Contact> GetAllContacts();
        IEnumerable<Contact> GetContactsWithCompanyAndCountry();
        IEnumerable<Contact> GetFilterContact(int CountryId, int CompanyId);
    }
}
