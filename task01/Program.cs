// Написать программу, которая 
// 1. на вход принимает два числа и проверяет, 
// 2. является ли первое число квадратом второго.

// Например:
// a = 25, b = 5 -> да,
// a = 2, b = 10 -> нет,
// a = 9, b = -3 -> да,
// a = -3, b = 9 -> нет.

Console.Write("Введите целое число 1: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число 2: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA == numberB * numberB)
    {
     Console.Write($"Квадрат числа {numberB} = {numberA}");
    }

else
    {
     Console.Write($"Квадрат числа {numberB} не равняется {numberA}");
    }
