// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
Console.Write("Получен следующий массив: ");
int[] array = NewArrayRandom(5, 100, 999);
PrintArray(array);

int OdNum (int []arr) 
{
    int rez = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0) {
            rez = rez + arr[i];
        }
    }
    return rez;
}

int rez = OdNum(array);
Console.WriteLine($"Сумма нечентных элементов массива равна: {rez}");