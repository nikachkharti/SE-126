using System.Diagnostics.CodeAnalysis;

namespace SE_126MainConsoleApp
{
    public class Client
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }


    public class ClientEquilityComparer : IEqualityComparer<Client>
    {
        public bool Equals(Client x, Client y) => x.FirstName == y.FirstName && x.LastName == y.LastName;
        public int GetHashCode([DisallowNull] Client obj) => obj.FirstName.Length + obj.LastName.Length;
    }

}
