using Movie.Service.Interfaces;

namespace Movie.Service
{
    public class UnitOfWork : IUnitOfWork
    {
        public ICountryRepository Country { get; private set; }

        public UnitOfWork()
        {
            Country = new CountryRepository();
        }
    }
}
