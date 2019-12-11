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
    public class CityController : BaseController
    {
        private ICityService _cityService;
        public CityController(ICityService cityService)
        {
            _cityService = cityService;
        }
        // GET: api/City
        [HttpGet("cities")]
        public async Task<IEnumerable<City>> Cities()
        {
            return await _cityService.GetCities();
        }

        // GET: api/city/5
        [HttpGet("cityById/{id}")]
        public async Task<City> CityById(int id)
        {
            var city = await _cityService.GetCityById(id);
            return city;
        }

        // POST: api/addCity
        [HttpPost("addCity")]
        public async Task<IActionResult> Post([FromBody] CityRequestDTO city)
        {
            try
            {
                var addinCity = await _cityService.AddCity(city);

                return Ok(addinCity);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        // PUT: api/Country/5
        [HttpPut("updateCity/{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] CityRequestDTO city)
        {
            try
            {
                var updateCity = await _cityService.UpdateCity(id, city);

                return Ok(updateCity);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("deleteCity/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var deleteCity = await _cityService.DeleteCity(id);

                return Ok(deleteCity);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}