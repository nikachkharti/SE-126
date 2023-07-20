namespace OurBank.Models
{
    public class Account : IEquatable<Account>
    {
        public int Id { get; set; }
        public string Iban { get; set; }
        public string Currency { get; set; }
        public double Balance { get; set; }
        public int CustomerId { get; set; }
        public string Name { get; set; }

        public bool Equals(Account other)
        {
            return Iban == other.Iban;
        }
    }
}
