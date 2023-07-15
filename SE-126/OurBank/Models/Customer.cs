using System.Diagnostics.CodeAnalysis;

namespace OurBank.Models
{
    public class Customer /*: IEquatable<Customer>*/
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string IdentityNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public CustomerType CustomerType { get; set; }


        //public bool Equals(Customer other)
        //{
        //    return IdentityNumber == other.IdentityNumber && PhoneNumber == other.PhoneNumber;
        //}


        public override bool Equals(object obj)
        {
            return new CustomerEquilityComparer().Equals(this, obj as Customer);
        }

        public override int GetHashCode()
        {
            return new CustomerEquilityComparer().GetHashCode(this);
        }
    }


    class CustomerEquilityComparer : IEqualityComparer<Customer>
    {
        public bool Equals(Customer x, Customer y)
        {
            return x.IdentityNumber == y.IdentityNumber;
        }

        public int GetHashCode([DisallowNull] Customer obj)
        {
            return obj.IdentityNumber.GetHashCode();
        }
    }

}
