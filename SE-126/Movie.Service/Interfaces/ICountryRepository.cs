using Movie.Models;

namespace Movie.Service.Interfaces
{
    public interface ICountryRepository
    {
        List<Country> GetAllCountries();
    }
}
