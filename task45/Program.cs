﻿// Задача 68: Напишите программу 
// вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Вводим первое число:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вводим второе число:");
int n = Convert.ToInt32(Console.ReadLine());

int res = NaturalNumsRange(m, n);
Console.WriteLine($"{res}");

int NaturalNumsRange(int n, int m)
{
    if (n == 0) return m + 1;
    else if (m == 0) return NaturalNumsRange(n - 1, 1);
    else return NaturalNumsRange(n - 1, NaturalNumsRange(n, m - 1));
}