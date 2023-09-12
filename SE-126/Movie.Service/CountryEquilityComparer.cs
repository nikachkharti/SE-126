using Movie.Models;
using System.Diagnostics.CodeAnalysis;

namespace Movie.Service
{
    public class CountryEquilityComparer : IEqualityComparer<Country>
    {
        public bool Equals(Country x, Country y) => x.CountryId == y.CountryId && x.Name == y.Name;
        public int GetHashCode([DisallowNull] Country obj) => obj.CountryId;
    }
}
