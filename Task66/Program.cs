﻿/*Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

System.Console.WriteLine(SumNumbers(4,8));

int SumNumbers(int start, int end)
{
    if (start == end)
    {
        return end;
    }
    return (start + SumNumbers(start+1,end));
}