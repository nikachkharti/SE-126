using Movie.Repository;

namespace Movie.Service.Interfaces
{
    public interface IUnitOfWork
    {
        public ICountryService Country { get; }
        public IDirectorService Director { get; }
    }
}
