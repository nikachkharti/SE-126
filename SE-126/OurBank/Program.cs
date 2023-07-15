using OurBank.Models;
using OurBank.Repositories;
using System.Transactions;


//TODO
//1.დაამატეთ მომხმარებლის წაშლის ფუნქციონალი CSV რეპოზიტორისთვის.
    //1.2 როდესაც მომხმარებელი წაიშლება, ავტომატურად უნდა წაიშალოს ყველა ანგარიში რომელიც შექმნილია მის სახელზე.
//2.დაამატეთ მომხმარებლის წაშლის და ჩამატების ფუნქციონალი Json რეპოზიტორისთვის.
//3.შესაძლებელი უნდა იყოს ახალი ანგარიშის გახსნა ბანკის მომხმარებლისთვის ანუ Customer-ისთვის CSV რეპოზიტორისთვის.
//4.შესაძლებელი უნდა იყოს შექმნილი ანგარიშის გაუქმება CSV რეპოზიტორისთვის.



Customer newCustomer = new();
newCustomer.Id = 11;
newCustomer.Name = "Irakli";
newCustomer.PhoneNumber = "555337844";
newCustomer.IdentityNumber = "01025277441";
newCustomer.Email = "irakli@gmail.com";
newCustomer.CustomerType = CustomerType.Phyisical;


CustomerCsvRepository customerCsvRepository = new();
customerCsvRepository.Add(newCustomer);

