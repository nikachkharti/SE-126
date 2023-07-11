using OurBank.Models;

namespace OurBank.Repositories
{
    public class CustomerCsvRepository : ICustomerRepository
    {
        const string _filePath = @"../../../Data/Customers.csv";
        List<Customer> _customers = new();
        int newElementAdded = 0;

        public CustomerCsvRepository()
        {
            _customers = File
                .ReadAllLines(_filePath)
                .Skip(1)
                .Select(x => x.ToCustomer())
                .ToList();
        }

        public void Add(Customer model)
        {
            if (!_customers.Any(x => x.Equals(model)))
            {
                //ჩამატბეამდე შეამოწმეთ მაქსიმალური ID და ახალი ჩანაწერისთვის გაზრდეთ  + 1 ით
                model.Id = _customers.Max(x => x.Id) + 1;
                _customers.Add(model);
                //ახალი user დაიმახსოვრეთ ფაილში
                SaveChanges(model);
            }
        }

        private void SaveChanges(Customer customer)
        {
            File.AppendAllText(_filePath, customer.ToCsv());
        }
    }

    internal static class CustomerExtension
    {
        //ფაილში დამახსოვრებისთვის შექმენით კიდევ ერთი extension მეთოდი სახელად ToCsv()
        internal static string ToCsv(this Customer obj) => $"\n{obj.Id},{obj.Name},{obj.IdentityNumber},{obj.PhoneNumber},{obj.Email},{obj.CustomerType}";
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
