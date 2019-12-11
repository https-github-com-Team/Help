using HelpApp.Core.Contracts;
using HelpApp.Core.Models;
using HelpApp.Core.Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HelpApp.Core.Services
{
    public class PersonService : IPersonService
    {
        private readonly IUnitOfWork unitOfWork;
        public PersonService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<Person> AddPeople(PersonRequestDTO people)
        {
            return await unitOfWork.PersonRepository.AddPeople(people);
        }

        public async Task<Person> DeletePerson(int id)
        {
            return await unitOfWork.PersonRepository.DeletePerson(id);
        }

        public async Task<Person> GetPersonById(int id)
        {
            return await unitOfWork.PersonRepository.GetPersonById(id);
        }

        public async Task<IEnumerable<Person>> GetPersons()
        {
            return await unitOfWork.PersonRepository.GetPersons();
        }

        public async Task<Person> UpdatePerson(int id, PersonRequestDTO person)
        {
            return await unitOfWork.PersonRepository.UpdatePerson(id, person);
        }
    }
}
