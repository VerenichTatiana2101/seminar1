// Напишите программу, которая принимает
//  на вход три числа и выдаём максимальное из 
//  этих чисел.
//  Например:
//  2, 3, 7 -> 7
//  44, 5, 78 -> 78
//  22, 3, 9 -> 22

Console.Write("Введите целое число 1: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите целое число 2: ");
int B = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите целое число 3: ");
int C = Convert.ToInt32(Console.ReadLine());

int max = A;
if (B > max)
{
    max = B;
}
if (C > max)
{
    max = C;
}

Console.WriteLine($"Максимальное из чисел: {A}, {B}, {C} -> {max}");


