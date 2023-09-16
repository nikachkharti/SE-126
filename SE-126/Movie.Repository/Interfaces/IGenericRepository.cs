namespace Movie.Repository
{
    public interface IGenericRepository<T> where T : class, new()
    {
        Task<List<T>> GETAllAsyncProcedure(string procedureName, params object[] parameters);
        Task<List<T>> GETAllAsyncQuery(string query);
        Task<T> GETSingleAsyncQuery(string query);
        Task<T> GETSingleAsyncProcedure(string procedure, params object[] parameters);
        Task POSTQuery(string query);
        Task POSTProcedure(string procedure, params object[] parameters);
    }
}
