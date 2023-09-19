using Microsoft.Data.SqlClient;
using Movie.Models;
using Movie.Repository;
using Movie.Service.Interfaces;
using System.Data;
using System.Diagnostics.Metrics;
using System.IO;

namespace Movie.Service
{
    public class DirectorService : GenericRepository<DirectorModel>, IDirectorService
    {
        public async Task AddDirector(DirectorModel director)
        {
            await POSTProcedure("sp_addDirector", director.FirstName, director.FamilyName, director.DoB, director.DoD, director.Gender);
        }
        public async Task DeleteDirector(int id)
        {
            await POSTProcedure("sp_deleteDirector", id);

        }
        public async Task<List<DirectorModel>> GetAllDirectors()
        {
            return await GETAllAsyncProcedure("sp_getAllDirectors");
        }
        public async Task<DirectorModel> GetDirector(int id)
        {
            return await GETSingleAsyncProcedure("sp_getSingleDirector", id);
        }
        public async Task UpdateDirector(DirectorModel director)
        {
            await POSTProcedure("sp_updateDirector", director.DirectorId, director.FirstName, director.FamilyName, director.DoB, director.DoD, director.Gender);
        }
    }
}