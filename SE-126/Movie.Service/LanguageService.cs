using Movie.Models;
using Movie.Repository;
using Movie.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.Service
{
    internal class LanguageService : GenericRepository<LanguageModel>, ILanguageService
    {
        public async Task AddLanguage(LanguageModel language)
        {
            await POSTProcedure("sp_addLanguage", language.Language);
        }

        public async Task DeleteLanguage(int id)
        {
            await POSTProcedure("sp_deleteLanguage", id);
        }

        public async Task<List<LanguageModel>> GetAllLanguages()
        {
          var allLanguages =  await GETAllAsyncProcedure("sp_getAllLanguages");
            return allLanguages;
        }

        public async Task<LanguageModel> GetLanguage(int id)
        {
            var singleLanguage = await GETSingleAsyncProcedure("sp_getSingleLanguage", 118);
            return singleLanguage;
        }

        public async Task UpdateLanguage(int id, LanguageModel language)
        {
            await POSTProcedure("sp_updateLanguage", id, language.Language);
        }
    }
}
