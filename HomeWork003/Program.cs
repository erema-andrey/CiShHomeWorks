﻿// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

var array = FillArray(4);
Console.WriteLine();
Print (array);
  
int[] FillArray(int length)
{
    int[] array = new int[length];
    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(100,999);
    }
    return array;
}
void Print(int[] array)
{
     foreach(var item in array)
     {
        Console.WriteLine($"{item}, ");
     }
}
     int[] numbers = {345, 897, 568, 234};
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine(numbers[i]);
                    count++;
                }
            }
            Console.WriteLine("Чётных чисел в массиве: " + count);
            Console.ReadLine();



// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] FillArray(int length)
// {
//     int[] array = new int[length];
//     for(int i = 0; i < length; i++)
//     {
//         array[i] = new Random().Next(100,999);
//     }
//     return array;
// }
// void Priht(int[] array)
// {
//      foreach(var item in array)
//      {
//         Console.WriteLine($"{item}, ");
//      }
// }



// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// int[] FillArray(int length)
// {
//     int[] array = new int[length];
//     for(int i = 0; i < length; i++)
//     {
//         array[i] = new Random().Next(100,999);
//     }
//     return array;
// }
// void Priht(int[] array)
// {
//      foreach(var item in array)
//      {
//         Console.WriteLine($"{item}, ");
//      }
// }