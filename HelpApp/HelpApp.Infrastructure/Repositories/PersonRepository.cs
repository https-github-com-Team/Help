using HelpApp.Core.Contracts;
using HelpApp.Core.Models;
using HelpApp.Core.Models.DTO;
using HelpApp.Infrastructure.Db;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace HelpApp.Infrastructure.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        public HelpDbContext _db { get; set; }

        public PersonRepository(HelpDbContext db)
        {
            _db = db;
        }

        public async Task<Person> AddPeople(PersonRequestDTO people)
        {
            try
            {
                Person newPerosn = new Person()
                {
                    Name = people.Name,
                    Surname = people.Surname,
                    PhoneNumber = people.PhoneNumber
                };
                 _db.People.Add(newPerosn);
                await _db.SaveChangesAsync();

                return newPerosn;

            }
            catch (Exception ex)
            {
                throw  ex;
            }
        }

        public async Task<Person> DeletePerson(int id)
        {
            try
            {
                var deletePerson = await _db.People.FirstOrDefaultAsync(v => v.Id == id);
                if (deletePerson == null)
                    return null;

                _db.People.Remove(deletePerson);
                await _db.SaveChangesAsync();
                return deletePerson;
            }
            catch (Exception)
            {

                return null;
            }
        }



        public async Task<Person> GetPersonById(int id)
        {
            try
            {
                var Person = await _db.People.FirstOrDefaultAsync(v => v.Id == id);
                if (Person == null)
                    return null;
                return Person;

            }
            catch (Exception)
            {

                return null;
            }


        }

        public async Task<IEnumerable<Person>> GetPersons()
        {
            return await _db.People.ToListAsync();

        }

        public async Task<Person> UpdatePerson(int id, PersonRequestDTO person)
        {
            try
            {
                var UpdatePerson = await _db.People.FirstOrDefaultAsync(v => v.Id == id);
                if (UpdatePerson == null)
                    return null;

                UpdatePerson.Name = person.Name;
                UpdatePerson.Surname = person.Surname;
                UpdatePerson.PhoneNumber = person.PhoneNumber;
                await _db.SaveChangesAsync();
                return UpdatePerson;
            }
            catch (Exception)
            {

                return null;
            }
        }

       
    }
}
