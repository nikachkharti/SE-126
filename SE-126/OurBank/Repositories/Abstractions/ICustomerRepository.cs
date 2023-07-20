using OurBank.Models;

namespace OurBank.Repositories
{
    public interface ICustomerRepository
    {
        void Add(Customer model);
        void Remove(int id);
        Customer Get(int id);
    }
}
