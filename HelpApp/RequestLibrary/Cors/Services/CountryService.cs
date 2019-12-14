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
    public partial class Service : ICountryService
    {
       
        public async Task<RequestResult<CountryModel>> AddCountry(CountryModel country)
        {
            return await _requestSender.Response<CountryModel>("api/country/addCountry", request =>{
                request.RequestFormat = DataFormat.Json;
                request.AddBody(country);
            }, Method.POST);
        }

        public async Task<RequestResult<CountryModel>> DeleteCountry(int id)
        {
            return await _requestSender.Response<CountryModel>("api/country/deleteCountry", request => {
                request.AddQueryParameter("id", id.ToString());
            }, Method.DELETE);
        }

        public async Task<RequestResult<List<CountryModel>>> GetCountries()
        {
            return await _requestSender.Response<List<CountryModel>>("api/country/countries");
        }

        public async Task<RequestResult<CountryModel>> GetCountry(int id)
        {
            return await _requestSender.Response<CountryModel>("api/country/countryById",request=> {
                request.AddQueryParameter("id", id.ToString());
            });
        }

        public async Task<RequestResult<CountryModel>> UpdateCountry(int id, CountryModel country)
        {
            return await _requestSender.Response<CountryModel>("api/country/updateCountry", request => {
                request.RequestFormat = DataFormat.Json;
                request.AddBody(country);
                request.AddQueryParameter("id", id.ToString());
            }, Method.PUT);
        }
    }
}
