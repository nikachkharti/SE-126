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
        public async void Get_All_Countries()
        {
            var allCountries = await _unitOfWork.Country.GetAllCountries();
        }


        [Fact]
        public async void Add_New_Country()
        {
            await _unitOfWork.Country.AddCountry(new CountryModel
            {
                Country = "Test Country2"
            });
        }


        [Fact]
        public async void Get_Single_Country()
        {
            var actual = await _unitOfWork.Country.GetCountry(118);
        }

        [Fact]
        public async void Delete_Country()
        {
            await _unitOfWork.Country.DeleteCountry(639);
        }

        [Fact]
        public async void Update_Country()
        {
            CountryModel countryToUpdate = await _unitOfWork.Country.GetCountry(640);
            countryToUpdate.Country = "Test country2";

            await _unitOfWork.Country.UpdateCountry(countryToUpdate);

        }
    }
}
