using Basic_Web_API.Data.Entities;
using Basic_Web_API.Services.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basic_Web_API.API.API.Controllers
{
    [Route("api/CompaniesAPI")]
    [ApiController]
    public class CompaniesAPIController : ControllerBase
    {
        private readonly ICompanyService _companyService;

        public CompaniesAPIController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        public IEnumerable<Company> GetCompanies()
        {
            var companies = _companyService.GetAllCompanies();
            return companies;
        }


    }
}
