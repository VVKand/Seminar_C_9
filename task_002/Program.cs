﻿// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите натуральное максимальное число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное минимальное число: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SummaRec(N));

int SummaRec(int max)
{
    if (max==M) return M;
    return max + SummaRec(max-1);
}
