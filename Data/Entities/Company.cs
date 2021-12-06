using Microsoft.Azure.KeyVault.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Basic_Web_API.Data.Entities
{
    public class Company
    {
        public Company()
        {
            this.Contact = new HashSet<Contact>();
        }
        [Key]
        public int CompanyId { get; set; }

        [StringLength(100)]
        public string CompanyName { get; set; }

        public ICollection<Contact> Contact { get; set; }


    }
}
