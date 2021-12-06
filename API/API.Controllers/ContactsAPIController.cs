using Basic_Web_API.Data.Entities;
using Basic_Web_API.Services.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basic_Web_API.API.API.Controllers
{
    [Route("api/ContactsAPI")]
    [ApiController]
    public class ContactsAPIController : ControllerBase
    {
        private readonly IContactService _contactService;

        public ContactsAPIController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IEnumerable<Contact> GetContacts()
        {
            var contacts = _contactService.GetAllContacts();
            return contacts;
        }

        public IEnumerable<Contact> GetContactsCompanyAndCountry()
        {
            var contactsCC = _contactService.GetContactsWithCompanyAndCountry();
            return contactsCC;
        }

        public ActionResult<Contact> GetContactsFilter(int CompanyId, int CountryId)
        {


            var contactsF = _contactService.GetFilterContact(CountryId, CompanyId);

            if (contactsF == null)
            {
                return NotFound();
            }
            return Ok(contactsF);
        }
    }
}
