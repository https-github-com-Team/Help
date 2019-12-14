using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RequestLibrary.Cors;
using RequestLibrary.Cors.Services;
using RequestLibrary.Models;

namespace HelpApp.Front.Controllers
{
    [Route("[controller]")]
    public class CountryController : BaseController
    {

        [HttpGet("countries")]
        public async Task<IActionResult> Countries()
        {
            
            var response = await _service.GetCountries();

            return Ok(response);
        }

        [HttpGet("countryById")]
        public async Task<IActionResult> CountryById(int id)
        {

            var response = await _service.GetCountry(id);

            return Ok(response);
        }
        [HttpPost("addCountry")]
        public async Task<IActionResult> AddCountry([FromBody] CountryModel country)
        {
            var response = await _service.AddCountry(country);

            return Ok(response);
        }
        [HttpDelete("deleteCountry")]
        public async Task<IActionResult> Delete(int id)
        {
            var response = await _service.DeleteCountry(id);

            return Ok(response);
        }
        [HttpPut("updateCountry")]
        public async Task<IActionResult> UpdateCountry([FromBody] CountryModel country)
        {
            var response = await _service.UpdateCountry(country.Id, country);

            return Ok(response);
        }
    }
}