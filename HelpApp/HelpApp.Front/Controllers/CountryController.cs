using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using HelpApp.Front.DTOs;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HelpApp.Front.Controllers
{
    [Route("[controller]")]
    public class CountryController : BaseController
    {
        [HttpGet("countries")]
        public async Task<IActionResult> Countries()
        {
            var response = await _HttpClient.GetAsync(_Url + $"api/country/countries");

            response.EnsureSuccessStatusCode();

            var result = await response.Content.ReadAsStringAsync();

            var account = JsonConvert.DeserializeObject<List<ClientCountryDTO>>(result);

            return Ok(account);
        }
        [HttpPost("addCountry")]
        public async Task<IActionResult> AddCountry([FromBody] ClientCountryDTO country)
        {

            try
            {
                var json = JsonConvert.SerializeObject(country);
                var data = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await _HttpClient.PostAsync(_Url + $"api/country/addCountry", data);

                response.EnsureSuccessStatusCode();

                var result = await response.Content.ReadAsStringAsync();

                var account = JsonConvert.DeserializeObject<ClientCountryDTO>(result);

                if (account == null)
                    return BadRequest();

                return Ok(account);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}