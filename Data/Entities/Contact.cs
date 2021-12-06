using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Basic_Web_API.Data.Entities
{
    public class Contact
    {
        [Key]
        public int ContactId { get; set; }

        [StringLength(100)]
        public string ContactName { get; set; }

        
        public int CompanyId { get; set; }
        public Company Company { get; set; }


        public int CountryId { get; set; }
        public Country Country { get; set; }
        


    }
}
