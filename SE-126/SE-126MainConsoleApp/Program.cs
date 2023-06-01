
// ტექსტური

// 1. char  'Y'
// 2. string "Y"

//char testChar = 'z';
//string testString = "Nika";


// ლოგიკური true false

//bool result = false; 



// რიცხვითი

//1.მთელი


//byte   0 256
//sbyte  -128 127

//byte x = 200;
//sbyte y = 15;

//short 
//ushort


//int
//uint

//int f = 500;
//uint z = 12;


//long
//ulong

//long l = 50;

//2.ათწილადი


//float
//float testFloat = 10.2F;

//double
//double testDouble = 12.2;


//decimal
//decimal testDecimal = 12.1M;



//ააწყვეთ სარეგისტრაციო ფორმა
//შემოაყვანინეთ user-ს სახელი გვარი ასაკი
//შეომყვანილი მნიშვნელობა დაბეჭდეთ კონსოლში


Console.Write("First name: ");
string firstName = Console.ReadLine();

Console.WriteLine("------------------------------");

Console.Write("Last name: ");
string lastName = Console.ReadLine();

Console.WriteLine("------------------------------");

Console.Write("Age: ");
int age = int.Parse(Console.ReadLine());


Console.WriteLine("------------------------------");

//Console.WriteLine(firstName + " " + lastName + " " + age);
//Console.WriteLine($"Hello my name is {firstName} {lastName} I am {age} years old");
//Console.WriteLine("Hello my name is {0} {1} I am {2} years old", firstName, lastName, age);


//სტრინგის ფორმატირებისთვის (ვწერთ ტექსტის შიგნით)
//\t - ადგილის გამოტოვება
//\n - ახალ ხაზზე ჩამოტანა