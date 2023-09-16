using Movie.Models;

namespace Movie.Service.Interfaces
{
    public interface ICountryService
    {
        Task<List<CountryModel>> GetAllCountries();
        Task AddCountry(CountryModel country);
        Task<CountryModel> GetCountry(int id);
        Task DeleteCountry(int id);
        Task UpdateCountry(CountryModel country);




    }
}
