using Microsoft.Data.SqlClient;
using Movie.Models;
using Movie.Repository;
using Movie.Service.Interfaces;
using System.Data;

namespace Movie.Service
{
    public class CountryService : GenericRepository<CountryModel>, ICountryService
    {
        public Task AddCountry(CountryModel country)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCountry(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<CountryModel>> GetAllCountries()
        {
            var allCountries = await GETAllAsyncProcedure("sp_getAllSpecifcCountries", 118, 258);
            return allCountries;
        }

        public async Task<CountryModel> GetCountry(int id)
        {
            var result = await GETSingleAsyncProcedure("sp_getSingleCountry", 118);
            return result;
        }

        public Task UpdateCountry(CountryModel country)
        {
            throw new NotImplementedException();
        }
    }


}
