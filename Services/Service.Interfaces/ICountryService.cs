using Basic_Web_API.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basic_Web_API.Services.Service.Interfaces
{
    public interface ICountryService
    {
        int CreateCountry(Country country);
        void UpdateCountry(Company company);
        void DeleteCountry(int CountryId);

        IEnumerable<Country> GetAllCountries();
    }
}
