namespace Movie.Repository
{
    public class GenericRepository<T> : IGenericRepository<T>
    {
        public Task Add()
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(T item)
        {
            throw new NotImplementedException();
        }
    }
}
