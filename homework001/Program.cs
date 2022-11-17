//  Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.Write("Введите трехзначное число");
// int number = Convert.ToInt32(Console.ReadLine());
// int num = (( number / 10 ) % 10);
// Console.WriteLine(num);

// Console.Write("Введи трёхзначное число: ");
// int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
// string stringNumber = Convert.ToString(threeDigitNumber);
// Console.WriteLine("вторая цифра этого числа "+stringNumber[1]);



// Напишите программу, которая выводит третью цифру заданного числа или сообщает,что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


// Console.WriteLine("Введи число");
// int number = Convert.ToInt32(Console.ReadLine());
// string variable = Convert.ToString(number);
// if (variable.Length > 2)
// {
//     Console.WriteLine($"Третья цифра:" + variable[2]);
// }
// else
// {
//   Console.WriteLine("Третьей цифры нет");
// }




// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// Console.Write("Введи цифру, обозначающую день недели");
// int date = Convert.ToInt32(Console.ReadLine());

// if (date == 6 || date == 7)
// {
//   Console.WriteLine("Выходной");
// }
// else if(date < 1 || date > 7)
// {
//   Console.WriteLine("В неделе 7 дней");
// }
// else 
// {
//   Console.WriteLine("Рабочий день");
// }



// Console.Write("Введи цифру, обозначающую день недели");
// int dayNumber = Convert.ToInt32(Console.ReadLine());
// void CheckingTheDayOfTheWeek (int dayNumber) 
// {
//   if (dayNumber == 6 || dayNumber == 7) 
//   {
//   Console.WriteLine("(день выходной)  да");
//   }
//   else if (dayNumber < 1 || dayNumber > 7) 
//   {
//     Console.WriteLine("это не день недели");
//   }
//   else Console.WriteLine("(день не выходной)  нет");
// }

// CheckingTheDayOfTheWeek(dayNumber);