﻿// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int NumberDegree(int num1, int num2)
{
    if (num2 == 0 ) return 1;   
    else return num1 * (NumberDegree(num1, num2 - 1));  
}

Console.Clear();
Console.WriteLine("Вводим первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вводим второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());

int numDegree = NumberDegree(number1, number2);
Console.WriteLine(numDegree);