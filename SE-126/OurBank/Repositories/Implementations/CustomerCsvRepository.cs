using OurBank.Models;

namespace OurBank.Repositories
{
    public class CustomerCsvRepository : ICustomerRepository
    {
        const string _filePath = @"../../../Data/Customers.csv";
        List<Customer> _customers = new();
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
            //ჩამატბეამდე შეამოწმეთ მაქსიმალური ID და ახალი ჩანაწერისთვის გაზრდეთ  + 1 ით
            _customers.Add(model);
            //ახალი user დაიმახსოვრეთ ფაილში
        }
    }

    internal static class CustomerExtension
    {
        //ფაილში დამახსოვრებისთვის შექმენით კიდევ ერთი extension მეთოდი სახელად ToCsv()
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
