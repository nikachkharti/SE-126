namespace Movie.Repository
{
    public interface IGenericRepository<T> where T : class, new()
    {
        Task<List<T>> GETAllAsync(string procedureName);
    }
}
