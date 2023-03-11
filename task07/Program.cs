// Задача 12.
// Написать программу, которая на вход принимает два числа
// и выводит, является ли первое число кратным второму. И если число 1 не 
// кратно числу 2, то программа будет выводить остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int result = Remainder(number, number1);

// if (result == 0)
// {
//     Console.WriteLine("Кратно");
// }
// else
//     Console.WriteLine($"Не кратно, остаток {result}");

Console.WriteLine(result == 0 ? "Кратно" : $"Не кратно, остаток {result}");

int Remainder(int num, int num1)
{
    return number % number1;
}

