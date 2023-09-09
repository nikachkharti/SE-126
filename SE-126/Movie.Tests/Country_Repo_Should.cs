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


        [Fact]
        public void Add_New_Country()
        {
            _unitOfWork.Country.AddCountry(new Country
            {
                Name = "Test Country"
            });
        }


        [Fact]
        public void Get_Single_Country()
        {
            var actual = _unitOfWork.Country.GetCountry(118);
            var expected = new Country { CountryId = 118, Name = "Japan" };

            Assert.Equal(expected, actual);
        }
    }
}
