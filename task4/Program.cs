﻿// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine("Четные числа: ");

for (int i = 2; i <= number; i++)
{
    if (i % 2 == 0)
    {
    Console.WriteLine(i);
    }
}
