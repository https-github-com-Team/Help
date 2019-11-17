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
        public async Task<IEnumerable<Country>> Countries()
        {
            return await _countryService.GetCountries();
        }

        // GET: api/Country/5
        [HttpGet("countryById/{id}")]
        public async Task<Country> CountryById(int id)
        {
            var country = await _countryService.GetCountryById(id);
            return country;
        }

        // POST: api/Country
        [HttpPost("addCountry")]
        public async Task<IActionResult> Post([FromBody] CountryRequestDTO country)
        {
            try
            {
                var addinCountry = await _countryService.AddCountry(country);

                return Ok(addinCountry);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        // PUT: api/Country/5
        [HttpPut("updateCountry/{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] CountryRequestDTO country)
        {
            try
            {
                var updateCountry = await _countryService.UpdateCountry(id, country);

                return Ok(updateCountry);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("deleteCountry/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var deleteCountry = await _countryService.DeleteCountry(id);
                
                return Ok(deleteCountry);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
