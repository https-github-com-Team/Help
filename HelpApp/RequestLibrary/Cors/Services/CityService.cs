using RequestLibrary.Cors.Interfaces;
using RequestLibrary.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestLibrary.Cors.Services
{
    public partial class Service : ICityService
    {
        public async Task<RequestResult<CityModel>> AddCity(CityModel city)
        {
            return await _requestSender.Response<CityModel>("api/city/addCity", request =>
            {
                request.RequestFormat = DataFormat.Json;
                request.AddBody(city);
            }, Method.POST);
        }

        public async Task<RequestResult<CityModel>> DeleteCity(int id)
        {
            return await _requestSender.Response<CityModel>("api/city/deleteCity", request => {
                request.AddQueryParameter("id", id.ToString());
            }, Method.DELETE);
        }

        public async Task<RequestResult<List<CityModel>>> GetCities()
        {
            return await _requestSender.Response<List<CityModel>>("api/city/cities");
        }

        public async Task<RequestResult<CityModel>> GetCity(int id)
        {
            return await _requestSender.Response<CityModel>("api/city/cityById", request => {
                request.AddQueryParameter("id", id.ToString());
            });
        }

        public async Task<RequestResult<CityModel>> UpdateCity(int id, CityModel city)
        {
            return await _requestSender.Response<CityModel>("api/city/updateCity", request => {
                request.RequestFormat = DataFormat.Json;
                request.AddBody(city);
                request.AddQueryParameter("id", id.ToString());
            }, Method.PUT);
        }
    }
}
