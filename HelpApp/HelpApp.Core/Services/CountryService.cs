using HelpApp.Core.Contracts;
using HelpApp.Core.Models;
using HelpApp.Core.Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HelpApp.Core.Services
{
    public class CountryService : ICountryService
    {
        private readonly IUnitOfWork unitOfWork;

        public CountryService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<Country>> GetCountries()
        {
            return await unitOfWork.CountryRepository.GetCountries();
        }

        public async Task<Country> GetCountryById(int id)
        {
            return await unitOfWork.CountryRepository.GetCountryById(id);
        }

        public async Task<Country> AddCountry(CountryRequestDTO country)
        {
            return await unitOfWork.CountryRepository.AddCountry(country);
        }

        public async Task<Country> UpdateCountry(int id, CountryRequestDTO country)
        {
            return await unitOfWork.CountryRepository.UpdateCountry(id,country);
        }

        public async Task<Country> DeleteCountry(int id)
        {
            return await unitOfWork.CountryRepository.DeleteCountry(id);
        }
    }
}
