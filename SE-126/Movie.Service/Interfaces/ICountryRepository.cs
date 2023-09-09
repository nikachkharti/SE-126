using Movie.Models;

namespace Movie.Service.Interfaces
{
    public interface ICountryRepository
    {
        List<Country> GetAllCountries();
        void AddCountry(Country country);
        Country GetCountry(int id);
        void DeleteCountry(int id);
        void UpdateCountry(Country country);
    }
}
