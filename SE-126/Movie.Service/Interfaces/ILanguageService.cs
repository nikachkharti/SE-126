using Movie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.Service.Interfaces
{
    public interface ILanguageService
    {
        Task<List<LanguageModel>> GetAllLanguages();
        Task AddLanguage(LanguageModel language);
        Task<LanguageModel> GetLanguage(int id);
        Task DeleteLanguage(int id);
        Task UpdateLanguage(int id,LanguageModel language);
    }
}
