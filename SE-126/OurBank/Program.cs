using OurBank.Models;
using OurBank.Repositories;
using OurBank.Repositories.Implementations;
using System.Transactions;


//TODO
//1.2 როდესაც მომხმარებელი წაიშლება, ავტომატურად უნდა წაიშალოს ყველა ანგარიში რომელიც შექმნილია მის სახელზე.
//2.დაამატეთ მომხმარებლის წაშლის და ჩამატების ფუნქციონალი Json რეპოზიტორისთვის.



Customer newCustomer = new();
newCustomer.Id = 11;
newCustomer.Name = "Irakli";
newCustomer.PhoneNumber = "555337844";
newCustomer.IdentityNumber = "01025277441";
newCustomer.Email = "irakli@gmail.com";
newCustomer.CustomerType = CustomerType.Phyisical;


CustomerCsvRepository customerCsvRepository = new();
customerCsvRepository.Remove(11);



//Account newAccount = new();
//newAccount.Iban = "GETB123456789456123574";
//newAccount.Currency = "GEL";
//newAccount.Balance = 100;
//newAccount.CustomerId = 11;
//newAccount.Name = string.Empty;

//Account newAccount2 = new();
//newAccount2.Iban = "EUTB123456789456143574";
//newAccount2.Currency = "EUR";
//newAccount2.Balance = 100;
//newAccount2.CustomerId = 11;
//newAccount2.Name = string.Empty;


//Account newAccount3 = new();
//newAccount3.Iban = "USTB123456789456143574";
//newAccount3.Currency = "USD";
//newAccount3.Balance = 100;
//newAccount3.CustomerId = 11;
//newAccount3.Name = string.Empty;



