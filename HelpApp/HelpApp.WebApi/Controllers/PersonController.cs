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
    public class PersonController : BaseController
    {
        private IPersonService _personService;

        public PersonController(IPersonService PersonService)
        {
            _personService = PersonService;
        }

        //GET: api/person
        [HttpGet("person")]
        public async Task<IEnumerable<Person>> Peoples()
        {
            return await _personService.GetPersons();
        }
        //GET: api/person/5
        [HttpGet("PersonById/{id}")]
        public async Task<Person> GetPersonById(int id)
        {
            var person = await _personService.GetPersonById(id);
            return person;
        }

        //POST: api/addPerson
        [HttpPost("addPeople")]
        public async Task<IActionResult> Post([FromBody] PersonRequestDTO person)
        {
            try
            {
                var addPeople = await _personService.AddPeople(person);
                return Ok(addPeople);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut("updatePerson/{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] PersonRequestDTO person)
        {
            try
            {
                var updatePerson = await _personService.UpdatePerson(id, person);

                return Ok(updatePerson);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("deletePerson/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var deletePerson = await _personService.DeletePerson(id);

                return Ok(deletePerson);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}