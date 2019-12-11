using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using HelpApp.Core.Contracts;
using HelpApp.Core.Models;
using HelpApp.Core.Models.DTO;

namespace HelpApp.Core.Services
{
   public class CityService : ICityService
    {
        private readonly IUnitOfWork unitOfWork;
        public CityService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public async Task<City> AddCity(CityRequestDTO city)
        {
            return await unitOfWork.CityRepository.AddCity(city);
        }

        public async Task<City> DeleteCity(int id)
        {
            return await unitOfWork.CityRepository.DeleteCity(id);
        }

        public async Task<IEnumerable<City>> GetCities()
        {
            return await unitOfWork.CityRepository.GetCities();
        }


        public async Task<City> GetCityById(int id)
        {
            return await unitOfWork.CityRepository.GetCityById(id);
        }

        public async Task<City> UpdateCity(int id, CityRequestDTO city)
        {
            return await unitOfWork.CityRepository.UpdateCity(id, city);
        }
    }
}
