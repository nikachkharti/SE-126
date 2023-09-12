using Movie.Service.Interfaces;

namespace Movie.Service
{
    public class UnitOfWork : IUnitOfWork
    {
        public ICountryService Country { get; private set; }

        public UnitOfWork()
        {
            Country = new CountryService();
        }
    }
}
