using Movie.Models;

namespace Movie.Service.Interfaces
{
    public interface ICountryService
    {
        Task<List<Country>> GetAllCountries();
        Task AddCountry(Country country);
        Task<Country> GetCountry(int id);
        Task DeleteCountry(int id);
        Task UpdateCountry(Country country);
    }
}
