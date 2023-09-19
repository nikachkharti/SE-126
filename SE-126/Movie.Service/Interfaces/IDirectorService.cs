using Movie.Models;

namespace Movie.Service.Interfaces
{
    public interface IDirectorService
    {
        Task<List<DirectorModel>> GetAllDirectors();
        Task AddDirector(DirectorModel director);
        Task<DirectorModel> GetDirector(int id);
        Task DeleteDirector(int id);
        Task UpdateDirector(DirectorModel director);
    }
}
