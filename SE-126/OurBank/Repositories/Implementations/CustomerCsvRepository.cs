using OurBank.Models;

namespace OurBank.Repositories
{
    public class CustomerCsvRepository : ICustomerRepository
    {
        const string _filePath = @"../../../Data/Customers.csv";
        private readonly List<Customer> _customers = new();
        private readonly string _fileHeader = string.Empty;

        public CustomerCsvRepository()
        {
            _customers = SelectCustomers();
            _fileHeader = GetFileHeader();
        }

        public void Add(Customer model)
        {
            if (!_customers.Any(cust => cust.Equals(model)))
            {
                model.Id = _customers.Max(x => x.Id) + 1;
                _customers.Add(model);
                SaveChanges();
            }
        }

        private void SaveChanges()
        {
            var customerStrings = _customers.Select(x => x.ToCsv());
            File.WriteAllText(_filePath, $"{_fileHeader}\n");
            File.AppendAllLines(_filePath, customerStrings);
        }

        private List<Customer> SelectCustomers()
        {
            return File
                .ReadAllLines(_filePath)
                .Skip(1)
                .Select(x => x.ToCustomer())
                .ToList();
        }


        private string GetFileHeader() => File.ReadAllLines(_filePath)[0];
    }

    internal static class CustomerExtension
    {
        //ფაილში დამახსოვრებისთვის შექმენით კიდევ ერთი extension მეთოდი სახელად ToCsv()
        internal static string ToCsv(this Customer obj) => $"{obj.Id},{obj.Name},{obj.IdentityNumber},{obj.PhoneNumber},{obj.Email},{obj.CustomerType}".Trim();
        internal static Customer ToCustomer(this string input)
        {
            Customer result = new();
            string[] csvInput = input.Split(',');

            result.Id = int.Parse(csvInput[0]);
            result.Name = csvInput[1];
            result.IdentityNumber = csvInput[2];
            result.PhoneNumber = csvInput[3];
            result.Email = csvInput[4];
            result.CustomerType = (CustomerType)Enum.Parse(typeof(CustomerType), csvInput[5]);

            return result;
        }
    }
}
