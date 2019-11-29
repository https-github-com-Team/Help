using HelpApp.Core.Models;
using HelpApp.Core.Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HelpApp.Core.Contracts
{
    public interface IPersonService
    {
        Task<IEnumerable<Person>> GetPersons();
        Task<Person> GetPersonById(int id);
        Task<Person> AddPeople(PersonRequestDTO people);
        Task<Person> UpdatePerson(int id, PersonRequestDTO person);
        Task<Person> DeletePerson(int id);
    }
}
