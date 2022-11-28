// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


// int[] NewArrayRandom(int size, int min, int max)
// {
//     int[] arr = new int[size];
//     Random rnd = new Random();

//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rnd.Next(min, max + 1);
//     }
//     return arr;
// }

// void PrintArray(int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i < arr.Length - 1)
//             Console.Write($"{arr[i]}, ");
//         else Console.Write($"{arr[i]}");
//     }
//     Console.WriteLine("]");
// }
// Console.Write("Выводим массив на печать: ");
// int[] array = NewArrayRandom(5, 100, 999);
// PrintArray(array);

// int EvenNumber(int[] arr)
// {
//     int count = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] % 2 == 0) count++;
//     }
//     return count;
// }

// int evenNumber = EvenNumber(array);
// Console.WriteLine($"Количество четных чисел в массиве ----> {evenNumber}");


// Console.Write("Введите элементы массива:\t");
// int number = Convert.ToInt32(Console.ReadLine());
// int[] arry = new int[number];
// FillArray(array); 
// PrintArray(array);
// Console.WriteLine($"{"Количество четных чисел:\t",33}{EvenNum(array)}");

// int EvenNum(int[]arr)
// {
//      int amounts = 0;
//      foreach (int item in arr)
//      {
//           if (item % 2 == 0)
//           {
//              amounts++;
//           } 
//      }
//      return amounts;
// }   
                
// void FillArray(int[] arr)
// {
   
//     for(int i = 0; i < arr.length; i++)
//     {
//         arr[i] = new Random().Next(100,999);
//     }
// }

// void PrintArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i ++)
//     {
//         if (i == arr.Length - 1)
//         {
//             Console.WriteLine($"{arr[i]}");
//         }
//         else 
//         {
//             Console.Write($"{arr[i]}, ");
//         }
//     }

// }



// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

 


// var array = FillArray(4);
// Print (array);
// Console.WriteLine(); 
// EvenNum(array);
// Print(array);


//  int summ = 0;
//             for (int i = 0; i < 0; i++)
//             {
//                 for (int j = 0; j < 0; j++)
//                 {
//                 if (array[i, j]%2 != 0) summ += array[i, j];
//                 }
//             }
//             Console.WriteLine($"Сумма нечётных элементов массива: {summ}");


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