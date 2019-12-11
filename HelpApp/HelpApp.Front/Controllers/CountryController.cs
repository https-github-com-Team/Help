using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelpApp.Front.DTOs;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HelpApp.Front.Controllers
{
    [Route("api/[controller]")]
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
    }
}