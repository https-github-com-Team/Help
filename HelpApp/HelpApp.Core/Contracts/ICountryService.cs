using HelpApp.Core.Models;
using HelpApp.Core.Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HelpApp.Core.Contracts
{
    public interface ICountryService
    {
        Task<IEnumerable<Country>> GetCountries();
        Task<Country> GetCountryById(int id);
        Task<Country> AddCountry(CountryRequestDTO country);
        Task<Country> UpdateCountry(int id, CountryRequestDTO country);
        Task<Country> DeleteCountry(int id);

    }
}
