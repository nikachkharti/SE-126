using Movie.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Movie.Tests
{
    public class Language_Repo_Should
    {
        private readonly IUnitOfWork _unitOfWork;
        public Language_Repo_Should()
        {
            _unitOfWork = new UnitOfWork();
        }

        [Fact]

        public async void Add_New_Language()
        {
            await _unitOfWork.Language.AddLanguage(new LanguageModel
            {
                Language= "Test Language"
            });
        }

    }
}
