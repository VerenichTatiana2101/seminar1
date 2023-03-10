//Задача 2.
// Написать программу, которая
// на вход будет принимать два числа
// и выдаёт, какое число больше, а какое меньше.
// Например:
// a = 5, b = 7 -> max = 7
// a = 2, b = 10 -> max = 10
// a = -9, b = -3 -> max = -3

Console.Write("Введите целое число 1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число 2: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
    {
     Console.Write($"a = {a}, b = {b} -> Max {a}");
    }

else
    {
     Console.Write($"a = {a}, b = {b} -> Max {b}");
    }
