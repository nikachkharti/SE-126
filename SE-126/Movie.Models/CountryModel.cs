namespace Movie.Models
{
    public class CountryModel
    {
        public int CountryId { get; set; }
        public string Country { get; set; }

        public override string ToString() => $"{CountryId} {Country}";
    }
}
