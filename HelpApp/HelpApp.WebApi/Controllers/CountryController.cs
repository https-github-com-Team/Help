using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelpApp.Core.Contracts;
using HelpApp.Core.Models;
using HelpApp.Core.Models.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HelpApp.WebApi.Controllers
{
    public class CountryController : BaseController
    {
        private ICountryService _countryService;
        public CountryController(ICountryService countryService)
        {
            _countryService = countryService;
        }
        // GET: api/Country
        [HttpGet("countries")]
        public async Task<StandartAnswer<IEnumerable<Country>>> Countries()
        {
            return await _countryService.GetCountries();
        }

        // GET: api/Country?id=5
        [HttpGet("countryById")]
        public async Task<StandartAnswer<Country>> CountryById(int id)
        {
            var answer = await _countryService.GetCountryById(id);

            return answer;
        }

        // POST: api/Country
        [HttpPost("addCountry")]
        public async Task<StandartAnswer<Country>> Post([FromBody] CountryRequestDTO country)
        {
            var answer = await _countryService.AddCountry(country);

            return answer;
        }

        // PUT: api/Country?id=5
        [HttpPut("updateCountry")]
        public async Task<StandartAnswer<Country>> Put(int id, [FromBody] CountryRequestDTO country)
        {
            var answer = await _countryService.UpdateCountry(id, country);

            return answer;
        }

        // DELETE: api/ApiWithActions?id=5
        [HttpDelete("deleteCountry")]
        public async Task<StandartAnswer<Country>> Delete(int id)
        {
            var answer = await _countryService.DeleteCountry(id);

            return answer;
        }
    }
}
