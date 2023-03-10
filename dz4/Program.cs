// Напишите программу, которая принимает
//  на вход три числа и выдаём максимальное из 
//  этих чисел.
//  Например:
//  2, 3, 7 -> 7
//  44, 5, 78 -> 78
//  22, 3, 9 -> 22

Console.Write("Введите целое число 1: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите целое число 2: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите целое число 3: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.WriteLine($"Максимальное из чисел: {a}, {b}, {c} -> {max}");
