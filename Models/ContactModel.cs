using Basic_Web_API.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basic_Web_API.Models
{
    public class ContactModel
    {
        public int ContactId { get; set; }
        public string ContactName { get; set; }
        public List<Contact> Contacts { get; set; }
    }
}
