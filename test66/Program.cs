﻿		// Задача 66: Задайте значения M и N. Напишите программу,
        //  которая найдёт сумму натуральных элементов в промежутке от M до N.
		// M = 1; N = 15 -> 120
		// M = 4; N = 8. -> 30
		
		// Задача 66: Задайте значения M и N. Напишите программу, 
        // которая найдёт сумму натуральных элементов в промежутке от M до N.
		
		
		int CalculateSumm(int m, int n)
		{
			int start = m;
			int end = n;
			if(m > n)
			{
				start = n;
				end = m;
			}
			return (end + start)*(end - start + 1)/2;		}
		
		Console.WriteLine(CalculateSumm(72, 16));
	