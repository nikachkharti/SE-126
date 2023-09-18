using Movie.Service.Interfaces;

namespace Movie.Service
{
    public class UnitOfWork : IUnitOfWork
    {
        public ICountryService Country { get; private set; }
        public IDirectorService Director { get; private set; }
        public ILanguageService Language { get; private set; }


        public UnitOfWork()
        {
            Country = new CountryService();
            Director = new DirectorService();
            Language = new LanguageService();
        }
    }
}
