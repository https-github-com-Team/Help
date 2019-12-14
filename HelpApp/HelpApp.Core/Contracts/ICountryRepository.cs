using HelpApp.Core.Models;
using HelpApp.Core.Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HelpApp.Core.Contracts
{
    public interface ICountryRepository
    {
        Task<StandartAnswer<IEnumerable<Country>>> GetCountries();
        Task<StandartAnswer<Country>> GetCountryById(int id);
        Task<StandartAnswer<Country>> AddCountry(CountryRequestDTO country);
        Task<StandartAnswer<Country>> UpdateCountry(int id,CountryRequestDTO country);
        Task<StandartAnswer<Country>> DeleteCountry(int id);
    }
}
