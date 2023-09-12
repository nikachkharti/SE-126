using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.Repository
{
    public interface IGenericRepository<T>
    {
        Task<List<T>> GetAll();
        T GetById(int id);
        Task Add();
        Task Update(T item);
        Task Delete(int id);
    }
}
