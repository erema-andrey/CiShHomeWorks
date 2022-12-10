
// Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

System.Console.WriteLine(PrintNumbers(0, 10));

string PrintNumbers(int start, int end)

{

    if (start == end)

    {

        return start.ToString();

    }
    return (start + " " + PrintNumbers(++start, end));

}

