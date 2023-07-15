using OurBank.Models;
using OurBank.Repositories;
using System.Transactions;




Customer newCustomer = new();
newCustomer.Id = 11;
newCustomer.Name = "Irakli";
newCustomer.PhoneNumber = "555337844";
newCustomer.IdentityNumber = "01025277441";
newCustomer.Email = "irakli@gmail.com";
newCustomer.CustomerType = CustomerType.Phyisical;


CustomerCsvRepository customerCsvRepository = new();
customerCsvRepository.Add(newCustomer);

