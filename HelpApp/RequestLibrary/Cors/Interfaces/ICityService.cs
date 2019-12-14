using RequestLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestLibrary.Cors.Interfaces
{
    public interface ICityService
    {
        Task<RequestResult<CityModel>> GetCity(int id);
        Task<RequestResult<List<CityModel>>> GetCities();
        Task<RequestResult<CityModel>> AddCity(CityModel city);
        Task<RequestResult<CityModel>> UpdateCity(int id, CityModel city);
        Task<RequestResult<CityModel>> DeleteCity(int id);
    }
}
