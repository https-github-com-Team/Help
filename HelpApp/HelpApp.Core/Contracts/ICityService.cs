using HelpApp.Core.Models;
using HelpApp.Core.Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HelpApp.Core.Contracts
{
    public interface ICityService
    {
        Task<IEnumerable<City>> GetCities();
        Task<City> GetCityById(int id);
        Task<City> AddCity(CityRequestDTO city);
        Task<City> UpdateCity(int id, CityRequestDTO city);
        Task<City> DeleteCity(int id);
    }

}
