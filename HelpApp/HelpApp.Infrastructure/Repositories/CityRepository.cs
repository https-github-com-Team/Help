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
    public class CityRepository : ICityRepository
    {
        public HelpDbContext _db { get; set; }
        public CityRepository(HelpDbContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<City>> GetCities()
        {
            return await _db.Cities.ToListAsync();
        }

        public async Task<City> GetCityById(int id)
        {
            return await _db.Cities.SingleOrDefaultAsync(v => v.Id == id);
        }

        public async Task<City> AddCity(CityRequestDTO city)
        {
            try
            {
                City newCity = new City()
                {
                    Name = city.Name,
                    CountryId = city.CountryId
                };

                _db.Cities.Add(newCity);

                await _db.SaveChangesAsync();

                return newCity;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<City> UpdateCity(int id, CityRequestDTO city)
        {
            try
            {
                var updateCity = await _db.Cities.SingleOrDefaultAsync(x => x.Id == id);

                if (updateCity == null)
                    return null;

                updateCity.Name = city.Name;
                updateCity.CountryId = city.CountryId;
                await _db.SaveChangesAsync();
                return updateCity;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<City> DeleteCity(int id)
        {
            try
            {
                var deleteCity = await _db.Cities.FirstOrDefaultAsync(c => c.Id == id);

                if (deleteCity == null)
                    return null;

                _db.Cities.Remove(deleteCity);
                await _db.SaveChangesAsync();
                return deleteCity;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
