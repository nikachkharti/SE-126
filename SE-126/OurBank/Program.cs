using OurBank.Models;
using OurBank.Repositories;

// TODO

// 2.შექმენით ფუნქციონალი რომელიც პასუხისმგებელი იქნება ფაილში (ბაზაში) ახალი მომხმარბლის დარეგისტრირებაზე
// 2.3.Id პარამეტრის შეყვანა ხელით არ უნდა იყოს საჭირო, იგი უნდა გამოიანგარიშებოდეს ავტომატურად.
// 2.4.ფაილში ყველა მომხმარებელი უნდა იყოს უნიკალური(არ უნდა მეორდებოდეს)

//P.S. მონაცემებთან სამუშაოდ გამოიყენეთ მზა Extension მეთოდები...


Customer newCustomer = new();
//newCustomer.Id = 11;
newCustomer.Name = "Irakli";
newCustomer.PhoneNumber = "555337844";
newCustomer.IdentityNumber = "01025877441";
newCustomer.Email = "irakli@gmail.com";
newCustomer.CustomerType = CustomerType.Phyisical;


CustomerCsvRepository customerCsvRepository = new();
customerCsvRepository.Add(newCustomer);

