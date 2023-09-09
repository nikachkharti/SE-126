using Movie.Service.Interfaces;

namespace Movie.Tests
{
    public class Country_Repo_Should
    {
        private readonly IUnitOfWork _unitOfWork;
        public Country_Repo_Should()
        {
            _unitOfWork = new UnitOfWork();
        }

        [Fact]
        public void Get_All_Countries()
        {
            var allCountries = _unitOfWork.Country.GetAllCountries();
        }
    }
}
