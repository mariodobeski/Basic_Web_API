using Basic_Web_API.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basic_Web_API.Models
{
    public class CompanyModel
    {
        public int CompanyId;

        public string CompanyName { get; set; }

      public List<Company> Companies { get; set; }
    }
}
