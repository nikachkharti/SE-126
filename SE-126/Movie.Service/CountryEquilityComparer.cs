using Movie.Models;
using System.Diagnostics.CodeAnalysis;

namespace Movie.Service
{
    public class CountryEquilityComparer : IEqualityComparer<CountryModel>
    {
        public bool Equals(CountryModel x, CountryModel y) => x.CountryId == y.CountryId && x.Country == y.Country;
        public int GetHashCode([DisallowNull] CountryModel obj) => obj.CountryId;
    }
}
