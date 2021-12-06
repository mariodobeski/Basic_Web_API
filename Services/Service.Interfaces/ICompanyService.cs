using Basic_Web_API.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basic_Web_API.Services.Service.Interfaces
{
    public interface ICompanyService
    {
        int CreateCompany(Company company);
        void UpdateCompany(Company company);
        void DeleteCompany(int CompanyId);

        IEnumerable<Company> GetAllCompanies();
        
    }
}
