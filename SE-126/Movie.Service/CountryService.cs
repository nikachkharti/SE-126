using Microsoft.Data.SqlClient;
using Movie.Models;
using Movie.Repository;
using Movie.Service.Interfaces;
using System.Data;
using System.Diagnostics.Metrics;

namespace Movie.Service
{
    public class CountryService : GenericRepository<CountryModel>, ICountryService
    {
        public async Task AddCountry(CountryModel country)
        {
            await POSTProcedure("sp_addCountry", country.Country);
        }

        public async Task DeleteCountry(int id)
        {
            await POSTQuery($"DELETE FROM Country WHERE CountryId = ${id}");
        }

        public async Task<List<CountryModel>> GetAllCountries()
        {
            var allCountries = await GETAllAsyncProcedure("sp_getAllCountries");
            return allCountries;
        }

        public async Task<CountryModel> GetCountry(int id)
        {
            var result = await GETSingleAsyncProcedure("sp_getSingleCountry", id);
            return result;
        }

        public async Task UpdateCountry(CountryModel country)
        {
            await POSTProcedure("sp_updateCountry", country.CountryId, country.Country);
        }
    }


}
