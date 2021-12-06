using Basic_Web_API.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basic_Web_API.Models
{
    public class CountryModel
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public List<Country> Countries { get; set; }
    }
}
