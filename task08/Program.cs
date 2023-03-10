﻿// Задача 14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно
// одновременно 7 и 23. Например:
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число на кратность: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число на кратность: ");
int number2 = Convert.ToInt32(Console.ReadLine());

bool result = MultTwoNumbers(number, number1, number2);
Console.WriteLine(result ? "Да" : "Нет");

bool MultTwoNumbers(int number, int number1, int number2)
{
    return number % number1 == 0 && number % number2 == 0;
}




