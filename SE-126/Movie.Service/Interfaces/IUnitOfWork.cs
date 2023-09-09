namespace Movie.Service.Interfaces
{
    public interface IUnitOfWork
    {
        public ICountryRepository Country { get; }
    }
}
