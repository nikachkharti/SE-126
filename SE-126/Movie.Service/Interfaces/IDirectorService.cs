using Movie.Models;

namespace Movie.Service.Interfaces
{
    public interface IDirectorService
    {
        Task<List<Director>> GetAllDirectors();
        Task AddDirector(Director director);
        Task<Director> GetDirector(int id);
        Task DeleteDirector(int id);
        Task UpdateDirector(Director director);
    }
}
