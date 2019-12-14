using HelpApp.Core.Contracts;
using HelpApp.Core.Enums;
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
    public class CountryRepository : ICountryRepository
    {
        public HelpDbContext _db { get; set; }
        public CountryRepository(HelpDbContext db)
        {
            _db = db;
        }

        public async Task<StandartAnswer<IEnumerable<Country>>> GetCountries()
        {
            var answer = new StandartAnswer<IEnumerable<Country>>(); 
            try
            {
                answer.Data = await _db.Countries.ToListAsync();
                answer.Code = ResultCodes.Ok;
                answer.Description = "Sheherler";
             }
            catch (Exception ex)
            {
                answer.Code = ResultCodes.UnknownError;
                answer.ErrorMessage = ex.Message;
            }
            return answer;
        }

        public async Task<StandartAnswer<Country>> GetCountryById(int id)
        {
            var answer = new StandartAnswer<Country>();
            try
            {
                answer.Data = await _db.Countries.Include(c => c.Cities).SingleOrDefaultAsync(c => c.Id == id);
                answer.Code = ResultCodes.Ok;
            }
            catch (Exception ex)
            {
                answer.Code = ResultCodes.UnknownError;
                answer.ErrorMessage = ex.Message;
            }
            return answer;
        }

        public async Task<StandartAnswer<Country>> AddCountry(CountryRequestDTO country)
        {
            var answer = new StandartAnswer<Country>();


            try
            {
                if(String.IsNullOrEmpty(country.Name))
                {
                    answer.Code = ResultCodes.InvalidParameters;
                    answer.Description = "Sheherin adi null ve ya bos ola bilmez";
                    return answer;
                }
                if (_db.Countries.Any(c => c.Name.Contains(country.Name)))
                {
                    answer.Code = ResultCodes.AlreadyExists;
                    answer.Description = "Bele bir Sheher artiq var";
                    return answer;
                }

                Country newCountry = new Country()
                {
                    Name = country.Name
                };


                _db.Countries.Add(newCountry);

                await _db.SaveChangesAsync();
                answer.Data = newCountry;
                answer.Code = ResultCodes.Created;
            }
            catch (Exception ex)
            {
                answer.ErrorMessage = ex.Message;
                answer.Code = ResultCodes.UnknownError;
            }
            return answer;
        }

        public async Task<StandartAnswer<Country>> UpdateCountry(int id, CountryRequestDTO country)
        {

            var answer = new StandartAnswer<Country>();
            try
            {

                if (_db.Countries.Any(c => c.Name.Contains(country.Name)))
                {
                    answer.Code = ResultCodes.AlreadyExists;
                    answer.Description = "Bele bir sheher adi artiq var";
                    return answer;
                }
                var updateCountry =await _db.Countries.SingleOrDefaultAsync(x => x.Id == id);

                if (updateCountry == null)
                {
                    answer.Code = ResultCodes.NotFound;
                    answer.Description = "Database-de bele bir sheher adi yoxdu";
                    return answer;
                }

                updateCountry.Name = country.Name;
                updateCountry.AddedDate = DateTime.Now;
                await _db.SaveChangesAsync();
                answer.Data = updateCountry;
                answer.Code = ResultCodes.Ok;
            }
            catch (Exception ex)
            {
                answer.ErrorMessage = ex.Message;
                answer.Code = ResultCodes.UnknownError;
            }
            return answer;
        }

        public async Task<StandartAnswer<Country>> DeleteCountry(int id)
        {
            var answer = new StandartAnswer<Country>();
            try
            {
                var deleteCountry = await _db.Countries.Include(c => c.Cities).FirstOrDefaultAsync(c => c.Id == id);

                if (deleteCountry == null)
                { 
                    answer.Code = ResultCodes.NotFound;
                    answer.Description = "Sheheri tapmaq mumkun olmadi";
                    return answer;
                }

                if (deleteCountry.Cities!=null)
                {
                    _db.Cities.RemoveRange(deleteCountry.Cities);
                    await _db.SaveChangesAsync();
                }

                _db.Countries.Remove(deleteCountry);
                await _db.SaveChangesAsync();
                answer.Data = deleteCountry;
                answer.Code = ResultCodes.Ok;
            }
            catch (Exception ex)
            {

                answer.ErrorMessage = ex.Message;
                answer.Code = ResultCodes.UnknownError;
            }
            return answer;
        }
    }
}
