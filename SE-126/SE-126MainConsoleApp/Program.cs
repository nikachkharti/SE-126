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










//Console.Write("First number: ");
//int firstNumber = int.Parse(Console.ReadLine());
//Console.Write("Second number: ");
//int secondNumber = int.Parse(Console.ReadLine());
//Console.WriteLine("[+ - * /]");
//char operation = char.Parse(Console.ReadLine());



//switch (operation)
//{
//    case '+':
//        Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
//        break;
//    case '-':
//        Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
//        break;
//    case '*':
//        Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
//        break;
//    case '/':
//        Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
//        break;
//}



//if (operation == '+')
//{
//    Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
//}
//else if (operation == '-')
//{
//    Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
//}
//else if (operation == '*')
//{
//    Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
//}
//else if (operation == '/')
//{
//    Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
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







