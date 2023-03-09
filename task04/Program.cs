// Написать программу, которая 
// принимает на вход трёхзначное число,
// и на выход показывает последнюю цифру этого числа.
// Например:
// 456 -> 6
// 782 -> 2
// 918 -> 8

// Console.Write("Введите трёхзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int numLast = num %10;
// Console.WriteLine($"Последняя цифра числа {num} - {numLast}");

Console.Write("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num >= 100 && num < 1000)
{
    int numLast = num % 10;
    Console.WriteLine($"Последняя цифра числа {num} - {numLast}");
}

else
{
    Console.WriteLine("Данное число не является трёхзначным");
}

