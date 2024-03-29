﻿using SE_126MainConsoleApp;
using SE_126MainConsoleApp.CounterStrike;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Text.Json;



#region პირველი 2 ლექცია

// უნარული           ++ -- += -= *= /=
// ბინარული          +  -  *  /  %          > < >= <= == !=

//int x = 10;
//int y = 5;

//Console.WriteLine(x > y);
//Console.WriteLine(x < y);
//Console.WriteLine(x >= y);
//Console.WriteLine(x <= y);
//Console.WriteLine(x == y);
//Console.WriteLine(x != y);


//Console.WriteLine(x = x + 10);
//Console.WriteLine(x += 10);
//Console.WriteLine(x -= 10);
//Console.WriteLine(x *= 10);
//Console.WriteLine(x /= 10);


//Console.WriteLine(x + y);
//Console.WriteLine(x - y);
//Console.WriteLine(x * y);
//Console.WriteLine(10 / 2);  /*-> 5*/
//Console.WriteLine(10 % 2);   /*-> 0*/


//byte 0-255



//int first = 258; // Implicit
//byte second = checked((byte)first); // Explicit

//Console.WriteLine(second);


//double x = 10.2;
//float y = checked((float)x);


//string x = 12.ToString();


//int firstNumber = 12;
//int secondNumber = 13;



//switch (firstNumber)
//{
//    case > 5:
//        Console.WriteLine("METIA 5 -ze");
//        break;

//    case < 5:
//        Console.WriteLine("NAKLEBIA 5 -ze");
//        break;

//    default:
//        Console.WriteLine("SXVA");
//        break;
//}






//if (firstNumber > secondNumber)
//{
//    Console.WriteLine("MORE");
//}
//else if (secondNumber > firstNumber)
//{
//    Console.WriteLine("LESS");
//}
//else if (secondNumber > firstNumber)
//{
//    Console.WriteLine("LESS");
//}
//else if (secondNumber > firstNumber)
//{
//    Console.WriteLine("LESS");
//}
//else if (secondNumber > firstNumber)
//{
//    Console.WriteLine("LESS");
//}
//else
//{
//    Console.WriteLine("EQUALS");
//}
#endregion


#region 3 ლექცია


//1 დავალება

//int number = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Shemoiyvanet ricxvi");
//int number = int.Parse(Console.ReadLine());

//if (number == 5 || number == 10)
//{
//    Console.WriteLine("Ricxvi aris 10 an 5");
//}
//else
//{
//    Console.WriteLine("Sxva ricxvi");
//}

//switch (number)
//{
//    case 5:
//    case 10:
//        Console.WriteLine("Ricxvi aris 10 an 5");
//        break;
//    default:
//        Console.WriteLine("Sxva ricxvi");
//        break;
//}




//2 დავალება

//Console.WriteLine("Shemoiyvanet ricxvi");
//int number = int.Parse(Console.ReadLine());

//if (number % 2 == 0)
//{
//    Console.WriteLine("EVEN");
//}
//else
//{
//    Console.WriteLine("ODD");
//}

//bool check = number % 2 == 0;
//switch (check)
//{
//    case true:
//        Console.WriteLine("EVEN");
//        break;
//    default:
//        Console.WriteLine("ODD");
//        break;
//}


//3 დავალება
//Console.WriteLine("Enter the letter");
//char letter = char.Parse(Console.ReadLine());

//if (letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U')
//{
//    Console.WriteLine("VOWEL");
//}
//else
//{
//    Console.WriteLine("CONSONANT");
//}


//switch (letter)
//{
//    case 'A':
//    case 'E':
//    case 'I':
//    case 'O':
//    case 'U':
//        Console.WriteLine("VOWEL");
//        break;
//    default:
//        Console.WriteLine("CONSONANT");
//        break;
//}


//4 დავალება

//int dayAsNumber = int.Parse(Console.ReadLine());

//switch (dayAsNumber)
//{
//    case 1:
//        Console.WriteLine("Monday");
//        break;
//    case 2:
//        Console.WriteLine("Tuesday");
//        break;
//    case 3:
//        Console.WriteLine("Wednesday");
//        break;
//    case 4:
//        Console.WriteLine("Thursday");
//        break;
//    case 5:
//        Console.WriteLine("Friday");
//        break;
//    case 6:
//        Console.WriteLine("Satuarday");
//        break;
//    case 7:
//        Console.WriteLine("Sunday");
//        break;
//}




//LOOP - ციკლი
//for while foreach do while


//int counter = 0;
//while (counter < 5)
//{
//    Console.WriteLine("Nika");
//    counter++;
//}


//for (int counter = 0; counter <= 5; counter++)
//{
//    Console.WriteLine("Nika");
//}



//do
//{
//    Console.WriteLine("Nika");
//}
//while (counter < 5);


//string[] names = { "Giorgi", "Daviti", "Genadi" };
//foreach (var item in names)
//{
//    Console.WriteLine(item);
//}


//char letter = char.Parse(Console.ReadLine());
//if (letter >= 65 && letter <= 90)
//{
//    Console.WriteLine("UPPER");
//}
//else
//{
//    Console.WriteLine("LOWER");
//}


//for (int i = 1; i < 9; i++)
//{
//    for (int j = 1; j < 9; j++)
//    {
//        Console.WriteLine($"{i}*{j}={i * j}");
//    }
//}


#endregion



#region ლექცია 4


//1. for ციკლის გამოყენებით კონსოლში დაბეჭდეთ რიცხვები 1 - დან 10 -ის ჩათვლით.


//for (int i = 1; i <= 10; i++)
//{
//    if (i == 3)
//    {
//        break;
//    }

//    Console.WriteLine(i);
//}


//int i = 1;
//while (i <= 10)
//{
//    if (i == 3)
//    {
//        break;
//    }
//    Console.WriteLine(i);
//    i++;
//}


//int x = 10;
//x = 15;

//Console.WriteLine(x);


//int[] array = { 10, 20, 30, 12 };

//Console.WriteLine(array[3]);
//Console.WriteLine(array[2]);
//Console.WriteLine(array[1]);
//Console.WriteLine(array[0]);


// დაბეჭდეთ  მასივი უკუღმა
//for(int i = array.Length - 1; i >= 0; i--)
//{
//    Console.WriteLine(array[i]);
//}



//მომხმარებელს შემოაყვანინეთ რიცხვი და კონსოლში დაბეჭდეთ true - თუ შემოყვანილ რიცხვს შეიცავს მასივი
//სხვა შემთხვევაში დაბეჭდეთ false



//int[] randomArray = new int[3] { 10, 20, 30 };
//int number = int.Parse(Console.ReadLine());

//for (int i = 0; i < randomArray.Length; i++)
//{
//    if (randomArray[i] == number)
//    {
//        Console.WriteLine(true);
//        break;
//    }
//}



//მოძებნეთ მასივში დადებითი ელემენტების რაოდენობა


//int[] ar = { 10, 1, 1, -5, -22 };

//int sum = 0;
//for (int i = 0; i < ar.Length; i++)
//{
//    if (ar[i] > 0)
//    {
//        sum += ar[i];
//    }
//}


//Console.ReadLine();




#endregion




#region ლექცია 5


//int[] intCollection = { 10, 20, 30, 10, 30, 100 };

//Console.WriteLine(FindIndex(intCollection, 30));



//int Sum(int[] integerArray)
//{
//    int sum = 0;
//    for (int i = 0; i < integerArray.Length; i++)
//    {
//        sum += integerArray[i];
//    }

//    return sum;
//}

//int FindMaxElement(int[] intArray)
//{
//    int maxElement = intCollection[0];
//    for (int i = 0; i < intCollection.Length; i++)
//    {
//        if (intCollection[i] > maxElement)
//        {
//            maxElement = intCollection[i];
//        }
//    }

//    return maxElement;
//}

//void Distinct(int[] intCollection)
//{
//    for (int i = 0; i < intCollection.Length; i++)
//    {
//        bool notUnique = false;
//        for (int j = 0; j < intCollection.Length; j++)
//        {
//            if (i != j && intCollection[i] == intCollection[j])
//            {
//                notUnique = true;
//                break;
//            }
//        }

//        if (!notUnique)
//        {
//            Console.WriteLine(intCollection[i]);
//        }
//    }
//}

//int[] Sort(int[] intCollection)
//{
//    for (int i = 0; i < intCollection.Length - 1; i++)
//    {
//        for (int j = i + 1; j < intCollection.Length; j++)
//        {
//            if (intCollection[j] < intCollection[i])
//            {
//                int t = intCollection[j];
//                intCollection[j] = intCollection[i];
//                intCollection[i] = t;
//            }
//        }
//    }

//    return intCollection;
//}

//int FirstOrDefault(int[] intCollection, int numberToFind)
//{
//    for (int i = 0; i < intCollection.Length; i++)
//    {
//        if (intCollection[i] == numberToFind)
//        {
//            return intCollection[i];
//        }
//    }
//    return 0;
//}

//int FindIndex(int[] intCollection, int numberToFind)
//{
//    for (int i = 0; i < intCollection.Length; i++)
//    {
//        if (intCollection[i] == numberToFind)
//        {
//            return i;
//        }
//    }
//    return 0;
//}






//int x = FunctionWithNumber();

//Console.WriteLine(++x);


//void Test()
//{
//    Console.WriteLine("test");
//}


//int FunctionWithNumber()
//{
//    return 10;
//}



#endregion



#region ლექცია 6

//საკლასო სავარჯიშო:
//პირველ გაკვეთილზე შესრულებული დავალება კალკულატორი გადაანაწილეთ
//ფუნქციებში ისე რომ თითოეული ოპერაცია (მიმატება,გამოკლება,გამრავლება,გაყოფა)
//იყოს ინდივიდუალური ფუნქცია.

//აუცილებელი პირობა: კალკულატორი არ უნდა წყვეტდეს მუშაობას პირველივე შესრულებული
//ოპერაციის
//შემდეგ, პროგრამა უნდა მუშაობდეს როგორც რეალური კალკულატორი იქამდე სანამ მომხმარებელი
//არ მოისურვებს აპლიკაციის შეჩერებას.

//PrintInFile(name);
//PrintInConsole(name);

//int x = Sum(5, 10);

//PrintInFile(x.ToString());

//int Sum(int number1, int number2)
//{
//    return number1 + number2;
//}

//void PrintInFile(string name)
//{
//    File.WriteAllText(@"../../../logger.txt", $"Me var {name}");
//}

//void PrintInConsole(string name)
//{
//    Console.WriteLine($"Me var {name}");
//}



#endregion




#region ლექცია 7



//Student std1 = new();
//std1.firstName = "Nika";
//std1.lastName = "Giorgadze";
//// პირადი ნომერი უნდა მიენიჭოს მხოლოდ იმ შემთხვევაში თუ
//// სიგრძე არის 11
//std1.SetPin("01024085083");
//std1.SetAge(12);


//Console.WriteLine($"{std1.firstName} {std1.lastName} {std1.GetAge()} {std1.GetPin()}");



//Console.ReadLine();




//class Person
//{
//    public string name;
//    public int age;

//    public void DsiplayInfo()
//    {
//        Console.WriteLine(name);
//    }

//    public Person(string name, int age)
//    {
//        this.name = name;
//        this.age = age;

//        Console.WriteLine($"{this.name} {this.age}");
//    }

//    public Person(int x)
//    {
//    }


//    public Person(string x)
//    {
//    }

//    public Person()
//    {
//    }
//}







#endregion



#region ლექცია 8



//Person person1 = new Person();
//person1.FirstName = "giorgi";
//person1.LastName = "giorgadze";
//person1.Age = 30;
//person1.Pin = "01024085741";


//Console.WriteLine($"{person1.FirstName} {person1.LastName} {person1.Age} {person1.Pin}");




//⦁	დაწერეთ ანგარიშს კლასი, რომელსაც ექნება
//⦁	ანგარიშის ნომერი (22 ნიშნა)
//⦁	ვალუტა(სამნიშნა)
//⦁	ბალანსი(არ უნდა იყოს უარყოფითი)

//⦁	დაწერეთ კლიენტის კლასი, რომელსაც ექნება
//⦁	სახელი
//⦁	გვარი
//⦁	პირადი ნომერი (11 ნიშნა)
//⦁	ანგარიში

//მოახდინეთ თქვენს მიერ შექმნილი კლასების დემონსტრირება კონსოლში.



//Account nikasAccount = new Account();
//nikasAccount.AccountNumber = "GETB012547896547123578";
//nikasAccount.Currency = "GEL";
//nikasAccount.Balance = 100;


//Account nikasAccount = new Account()
//{
//    AccountNumber = "GETB012547896547123578",
//    Currency = "GEL",
//    Balance = 100,
//};



//Client clientNika = new Client();
//clientNika.FirstName = "Nika";
//clientNika.LastName = "Chkhartishvili";
//clientNika.Pin = "01257412359";
////clientNika.Account = nikasAccount;
//clientNika.Account = new Account()
//{
//    AccountNumber = "GETB012547896547123578",
//    Currency = "GEL",
//    Balance = 100,
//};



//Console.WriteLine($"{clientNika.FirstName} {clientNika.LastName} has {clientNika.Account.Balance} {clientNika.Account.Currency}");


// დაამატეთ თანხის განაღდების და ბალანსზე თანხის შეტანის ფუნქციონალი.

#endregion



#region ლექცია 9 10 11


//გავრცელებული ტიპები მონაცემებთნ სამუშაოდ
// JSON
// CSV -- Comma Separated Value
// XML


// SQL





//string[] data = File.ReadAllLines(@"../../../vehicles.csv");
//Car[] cars = Algorithms.Select(data);


//Car[] economicCars = Algorithms.Sort(cars);
//Car[] topTenEcnomicCars = Algorithms.Take(economicCars, 10);


//string[] economicCarsAsString = new string[topTenEcnomicCars.Length];
//for (int i = 0; i < topTenEcnomicCars.Length; i++)
//{
//    economicCarsAsString[i] = topTenEcnomicCars[i].ToString();
//}

//File.WriteAllLines(@"../../../economicVehicles.txt", economicCarsAsString);


//string economicCarsAsJson = JsonSerializer.Serialize(topTenEcnomicCars, new JsonSerializerOptions() { WriteIndented = true });
//File.WriteAllText(@"../../../economicVehicles.json", economicCarsAsJson);


//string carsAsJsonString = File.ReadAllText(@"../../../economicVehicles.json");

//List<Car> deserializedCars = JsonSerializer.Deserialize<List<Car>>(carsAsJsonString);




#endregion



#region ლექცია 12

//string[] data = File.ReadAllLines(@"../../../vehicles.csv");
//Car[] cars = Algorithms.Select(data);



//List<int> intList = new() { 1, 2, 1, 10, 11, 15 };
//List<string> names = new() { "nika", "irakli", "elene" };


//int[] ar = { 1, 2, 1, 10, 11, 15, 2 };
//string[] arNames = { "nika", "elene", "irakli", "elene" };
//var result = Algorithms.LastOrDefault(arNames, "elene");






#endregion


#region ლექცია 14




//var data =
//    File.ReadAllLines(@"../../../vehicles.csv")
//    .Select(x => Car.Parse(x));

//string[] stringData = { "10", "-21", "3", "16" };

//int[] intData = stringData
//.Select(x => int.Parse(x))
//.Sort((x, y) => x < 0);





//Console.ReadLine();

#endregion



#region ლექცია 15


//Person person1 = new()
//{
//    FirstName = "Giorgi",
//    LastName = "Giorgadze"
//};



//Employee employee1 = new()
//{
//    FirstName = "Davit",
//    LastName = "Davitidze",
//    Salary = 500
//};

//Student std1 = new Student()
//{
//    FirstName = "Giorgi",
//    LastName = "Menteshashvili",
//    Score = 99.9,
//    Subject = new Subject()
//    {
//        Title = "C#",
//        Credit = 20
//    }
//};


//Teacher teacher1 = new()
//{
//    FirstName = "Nika",
//    LastName = "Chkhartishvili",
//    Salary = 1000,
//    Subject = new Subject()
//    {
//        Title = "C#",
//        Credit = 20
//    }
//};

//Administration admin1 = new()
//{
//    FirstName = "Tets",
//    LastName = "Test",
//    Salary = 100000,
//};





//IntroduceYourself(std1);
//IntroduceYourself(teacher1);
//IntroduceYourself(admin1);


//void IntroduceYourself(Person obj)
//{
//    obj.Talk();
//}


//abstract class Person
//{
//    public string FirstName { get; set; }
//    public string LastName { get; set; }
//    public abstract void Talk();
//}

////abstract class Person
////{
////    public string FirstName { get; set; }
////    public string LastName { get; set; }
////    public virtual void Talk()
////    {
////        Console.WriteLine("HI");
////    }
////}

//abstract class Employee : Person
//{
//    public double Salary { get; set; }
//}

//class Student : Person
//{
//    public double Score { get; set; }
//    public Subject Subject { get; set; } // კომპოზიცია

//    //პოლიმორფიზმი
//    public override void Talk()
//    {
//        Console.WriteLine($"Hello My name is {FirstName} {LastName} I have a score {Score} I study {Subject.Title}");
//    }
//}

//class Subject
//{
//    public string Title { get; set; }
//    public double Credit { get; set; }
//}

//class Teacher : Employee
//{
//    public Subject Subject { get; set; }

//    //პოლიმორფიზმი
//    public override void Talk()
//    {
//        Console.WriteLine($"Hello My name is {FirstName} {LastName} I am a teacher, I have salary {Salary} GEL, I teach {Subject.Title}");
//    }
//}

//class Administration : Employee
//{
//    //პოლიმორფიზმი
//    public override void Talk()
//    {
//        Console.WriteLine($"Hello My name is {FirstName} {LastName} I am an administartor, I have salary {Salary} GEL");
//    }
//}








#endregion



#region ლექცია 16


/////////////დაწერეთ Counter - ის იარაღის ყიდვის ლოგიკა//////////////////////


//უნდა მყავდეს Player შემდეგი პარამეტრებით
//1.სიცოცხლე
//2.ფული

//გვქონდეს 4 ტიპის იარაღი პისტოლეტი,ავტომატური,დანა
//იარაღს უნდა ქონდეს ფასი Damage
// დავალების შესასრულებლად გამოიყენეთ ინტერფეისები და აბსტრაქტული კლასები



//TODO -- დაამატეთ იარაღის გასროლის ლოგიკა (ერთმა ფლეირმა უნდა ესროლოს მეორეს)
//TODO -- დაამატეთ იარაღის გადატენვის ლოგიკა
//TODO -- დაამატეთ იარაღის ყიდვის ლოგიკა







//abstract class Bird
//{
//    public int Health { get; set; } = 100;
//}

//interface IFlyer
//{
//    public abstract void Fly();
//}

//interface IInterface
//{

//}

//class Eagle : Bird, IFlyer, IInterface
//{
//    public void Fly()
//    {
//        Console.WriteLine("FLYING HIGH...");
//    }
//}

//class Penguin : Bird
//{

//}


//interface IUserService
//{
//    void Login();
//}

//interface IEmployeeService
//{
//    void PaySeller();
//}

//class AdministrationService : IUserService, IEmployeeService
//{
//    public void Login()
//    {
//        throw new NotImplementedException();
//    }

//    public void PaySeller()
//    {
//        throw new NotImplementedException();
//    }
//}

//class TeacherService : IUserService, IEmployeeService
//{
//    public void Login()
//    {
//        throw new NotImplementedException();
//    }

//    public void PaySeller()
//    {
//        throw new NotImplementedException();
//    }
//}

//class StudentService : IUserService
//{
//    public void Login()
//    {

//    }
//}



//public abstract class Animal
//{
//    public abstract void MakeVoice();
//}

//class Dog : Animal
//{
//    public override void MakeVoice()
//    {
//        Console.WriteLine("HAU HAU");
//    }
//}

//class Cat : Animal
//{
//    public override void MakeVoice()
//    {
//        Console.WriteLine("Meow");
//    }
//}






#endregion


#region ლექცია 17




//List<int> intList = new() { 10, -20, 1, 3 };


//string[] intAr = { "10", "20", "3", "1"};
//var res = intAr.Select((x,y)=>int.Parse(x));



//HashSet<int> inSet = new() { 1, 1, 1, 1, 10, 10, 2, 13, -4 };
//Dictionary<int, string> numbersDictionary = new Dictionary<int, string>();
//numbersDictionary.Add(1, "erti");
//numbersDictionary.Add(2, "ori");
//numbersDictionary.Add(3, "sami");













//numbersDictionary.TryGetValue(12, out string foundElement);
//bool isAded = numbersDictionary.TryAdd(6, "sami");
//string x = "120ASA";
//if (int.TryParse(x, out var parsedResult))
//{
//    Console.WriteLine(parsedResult++);
//}




//Console.ReadLine();

Console.WriteLine();

#endregion









//List<Car> cars = new();
//using (StreamReader reader = new(@"../../../vehicles.csv"))
//{
//    try
//    {
//        while (!reader.EndOfStream)
//        {
//            string line = reader.ReadLine();
//            cars.Add(Car.Parse(line));
//        }
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine(ex.Message);
//    }
//}


//using (StreamWriter writer = new(@"../../../test.txt", true))
//{
//    try
//    {
//        writer.WriteLine($"Hello World 2");
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine(ex.Message);
//    }
//}



//try
//{
//    while (!reader.EndOfStream)
//    {
//        string line = reader.ReadLine();
//        cars.Add(Car.Parse(line));
//    }
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//finally
//{
//    reader.Close();
//    reader.Dispose();
//}



Console.ReadKey();

