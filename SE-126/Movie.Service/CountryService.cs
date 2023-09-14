using Microsoft.Data.SqlClient;
using Movie.Models;
using Movie.Repository;
using Movie.Service.Interfaces;
using System.Data;

namespace Movie.Service
{
    public class CountryService : GenericRepository<Country>, ICountryService
    {
        public Task AddCountry(Country country)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCountry(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Country>> GetAllCountries()
        {
            var allCountries = await GETAllAsync("sp_getAllCountries");
            return allCountries;
        }

        public Task<Country> GetCountry(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCountry(Country country)
        {
            throw new NotImplementedException();
        }
    }


}
