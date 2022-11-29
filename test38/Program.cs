// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] NewArrayRandom(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
            Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

void MinMax ( int[] arr) 
{
    Array.Sort(arr);
    int max = arr[arr.Length-1];
    int min = arr[0];
    int minMax = max - min;
    Console.WriteLine($"Максимальное значение в массиве: {max}, минимальное: {min}, и их разница равна: {minMax}");
}

Console.Write("Получен следующий массив: ");
int[] array = NewArrayRandom(5, 100, 999);
PrintArray(array);
MinMax(array);