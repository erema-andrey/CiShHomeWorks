﻿// Напишите программу, которая принимает на вход пятизначное число и проверяет,
//  является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.Write("Введите число: ");
// string? number = Console.ReadLine();

// void CheckingNumber(string number)
// {
//   if (number[0]==number[4] || number[1]==number[3])
// {
//     Console.WriteLine($"Ваше число: {number} - палиндром.");
//   }
//   else Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");
// }

// if (number!.Length == 5)
// {
//   CheckingNumber(number);
// }
// else Console.WriteLine($"Введи правильное число");






// Напишите программу, которая принимает на вход координаты двух точек
//  и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53



// Console.WriteLine("Введите значение x1:");
// var x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение y1:");
// var y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение z1:");
// var z1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение x2:");
// var x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение y2:");
// var y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение z2:");
// var z2 = Convert.ToInt32(Console.ReadLine());

// var result = Math.Sqrt(Math.Pow((x1-x2),2) + Math.Pow((y1-y2),2) + Math.Pow((z1-z2),2));

// Console.WriteLine(result);





// int x1 = Coordinate("x", "A");
// int y1 = Coordinate("y", "A");
// int z1 = Coordinate("z", "A");
// int x2 = Coordinate("x", "B");
// int y2 = Coordinate("y", "B");
// int z2 = Coordinate("z", "B");

// int Coordinate(string coorName, string pointName)
// {
//     Console.Write($"Введите координату {coorName} точки {pointName}: ");
//     return Convert.ToInt16(Console.ReadLine());
// }

// double Decision(double x1, double x2, double y1, double y2, double z1, double z2)
// {
//   return Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2));
// }

// double segmentLength =  Math.Round (Decision(x1, x2, y1, y2, z1, z2), 2 );

// Console.WriteLine($"Длина отрезка  {segmentLength}");








// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


// Console.WriteLine("Введите число: ");
// var num = Convert.ToInt32(Console.ReadLine());

// for (int i = 1; i <= num; i++)
// {
//     Console.WriteLine(Math.Pow(i,3));
// }



// Console.Write("Введите число: ");
// int cube = Convert.ToInt32(Console.ReadLine());
// void Cube(int[] cube)
// {
//   int counter = 0;
//   int length = cube.Length;
//   while (counter <  length)
// {
//     cube[counter] = Convert.ToInt32(Math.Pow(counter, 3));
//     counter++;
//   }
// }

// void PrintArry(int[] coll)
// {
//   int count = coll.Length;
//   int index = 0;
//   while(index < count)
// {
//     Console.Write(coll[index]+ " ");
//     index++;
//   }
// } 

// int[] arry = new int[cube+1];
// Cube(arry);
// PrintArry(arry);