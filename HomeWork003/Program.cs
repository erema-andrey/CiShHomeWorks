// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.WriteLine("введите число A");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите число B");
// int num1 = Convert.ToInt32(Console.ReadLine());
// int level = num;
// for (int i = 1; i < num1; i++)
// {
// level = level * num;
// }
// Console.WriteLine("A в степени B равно: " + level);





// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


// int GetSum(int num)
// {
//     int sum = 0;
//     for(int i = 0; i <= num; i++)
//     {
//         sum += i;
        
//     }
//     return  sum;
// }



// Console.WriteLine("введите число");
// int i = Convert.ToInt32(Console.ReadLine());
// int sum = 0;

// while (i > 0)
// {
// int num = i % 10;
// i = i / 10;
// sum = sum + num;
// }
// Console.WriteLine("сумма всех цифр в числе равна: " + sum);







// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33

int[] array = new int[8];
PrintArray(array);

Console.WriteLine();
var arr = FillArray(8);

PrintArray(arr);


int[] FillArray(int length)

{
   
int[] result = new int[length];
   
for(int i =0; i < result.Length; i++)
    
{
        
      result[i] = new Random().Next(0, 2);
    
}
    
return result;

}


void PrintArray(int[] arr)

{
    
for(int i = 0; i < arr.Length; i++)
    
{
       
 Console.Write($"{arr[i]}, ");
   
 }

}