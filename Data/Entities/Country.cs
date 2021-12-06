using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Basic_Web_API.Data.Entities
{
    public class Country
    {
        public Country()
        {
            this.Contact = new HashSet<Contact>();
        }
        [Key]
        public int CountryId { get; set; }

        [StringLength(100)]
        public string CountryName { get; set; }

        public ICollection<Contact> Contact { get; set; }

    }
}
