﻿// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число N: "); 
int n = int.Parse(Console.ReadLine());
int count = 1 ;
while (true)
{
    if (count <=n)
    {
        Console.Write($"{count}");
        count++; 
    }
    if (count % 2 == 0)
    {
        break;
    }
    
}


