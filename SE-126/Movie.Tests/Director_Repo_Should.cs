using Movie.Service;
using Movie.Service.Interfaces;

namespace Movie.Tests
{
    public class Director_Repo_Should
    {
        private readonly IUnitOfWork _unitOfWork;
        public Director_Repo_Should()
        {
            _unitOfWork = new UnitOfWork();
        }

        [Fact]
        public async void Get_All_Directors()
        {
            var allDirectors = await _unitOfWork.Director.GetAllDirectors();
        }


        [Fact]
        public async void Get_Single_Director()
        {
            var allDirectors = await _unitOfWork.Director.GetDirector(495);
        }


        [Fact]
        public async void Add_New_Director()
        {
            DirectorModel newDirector = new()
            {
                FirstName = "Nika",
                FamilyName = "Chkhartishivli",
                DoB = new DateTime(1995, 04, 06),
                DoD = new DateTime(2020, 04, 06),
                Gender = "Male"
            };

            await _unitOfWork.Director.AddDirector(newDirector);

        }
    }
}
