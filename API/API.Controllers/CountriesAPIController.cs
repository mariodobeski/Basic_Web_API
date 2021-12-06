using Basic_Web_API.Data.Entities;
using Basic_Web_API.Services.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basic_Web_API.API.API.Controllers
{
    [Route("api/CountriesAPI")]
    [ApiController]
    public class CountriesAPIController : ControllerBase
    {
        private readonly ICountryService _countryService;

        public CountriesAPIController(ICountryService countryService)
        {
            _countryService = countryService;
        }

        public IEnumerable<Country> GetCountries()
        {
            var countries = _countryService.GetAllCountries();
            return countries;
        }
    }
}
