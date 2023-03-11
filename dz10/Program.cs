﻿// Задача 10: Напишите программу, которая принимает 
// на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num >= 100 && num < 1000)
{
    int numLast = num / 10;
    int numLast1 = numLast % 10;
    Console.WriteLine($"Вторая цифра числа {num} - {numLast1}");
}

else
{
    Console.WriteLine("Данное число не является трёхзначным");
}
