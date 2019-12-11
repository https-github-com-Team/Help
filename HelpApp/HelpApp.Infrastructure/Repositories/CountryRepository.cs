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
    public class CountryRepository : ICountryRepository
    {
        public HelpDbContext _db { get; set; }
        public CountryRepository(HelpDbContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<Country>> GetCountries()
        {
            return await _db.Countries.Include(c=>c.Cities).ToListAsync();
        }

        public async Task<Country> GetCountryById(int id)
        {
            return await _db.Countries.Include(c => c.Cities).SingleOrDefaultAsync(c=>c.Id==id);
        }

        public async Task<Country> AddCountry(CountryRequestDTO country)
        {
            try
            {
                Country newCountry = new Country()
                {
                    Name = country.Name
                };

                _db.Countries.Add(newCountry);

                await _db.SaveChangesAsync();

                return newCountry;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<Country> UpdateCountry(int id, CountryRequestDTO country)
        {
            try
            {
                var updateCountry =await _db.Countries.SingleOrDefaultAsync(x => x.Id == id);

                if (updateCountry == null)
                    return null;

                updateCountry.Name = country.Name;
                await _db.SaveChangesAsync();
                return updateCountry;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<Country> DeleteCountry(int id)
        {
            try
            {
                var deleteCountry = await _db.Countries.Include(c => c.Cities).FirstOrDefaultAsync(c => c.Id == id);

                if (deleteCountry == null)
                    return null;

                if (deleteCountry.Cities!=null)
                {
                    _db.Cities.RemoveRange(deleteCountry.Cities);
                    await _db.SaveChangesAsync();
                }

                _db.Countries.Remove(deleteCountry);
                await _db.SaveChangesAsync();
                return deleteCountry;
            }
            catch (Exception)
            {
                return null;
            }

        }
    }
}
