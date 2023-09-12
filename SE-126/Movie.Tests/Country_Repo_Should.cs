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
        public async void Get_Single_Country()
        {
            var actual = await _unitOfWork.Country.GetCountry(118);
            var expected = new Country { CountryId = 118, Name = "Japan" };

            Assert.Equal(expected, actual, new CountryEquilityComparer());
        }

        [Fact]
        public void Delete_Country()
        {
            _unitOfWork.Country.DeleteCountry(638);
        }

        [Fact]
        public async void Update_Country()
        {
            Country countryToUpdate = await _unitOfWork.Country.GetCountry(640);
            countryToUpdate.Name = "Test country2";

            await _unitOfWork.Country.UpdateCountry(countryToUpdate);

        }
    }
}
