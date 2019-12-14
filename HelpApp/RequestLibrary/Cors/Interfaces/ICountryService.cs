using RequestLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestLibrary.Cors.Interfaces
{
    public interface ICountryService
    {
        Task<RequestResult<CountryModel>> GetCountry(int id);
        Task<RequestResult<List<CountryModel>>> GetCountries();
        Task<RequestResult<CountryModel>> AddCountry(CountryModel country);
        Task<RequestResult<CountryModel>> UpdateCountry(int id, CountryModel country);
        Task<RequestResult<CountryModel>> DeleteCountry(int id);
    }
}
