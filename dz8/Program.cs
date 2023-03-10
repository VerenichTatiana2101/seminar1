// Задача 8. 
// Напишите программу, которая 
// на вход принимает число (N), а 
// на выходе показывает все чётные числа от 1 до N.
// Например:
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Console.Write("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int count = 2;
// while (count <= N)
//     if (count % 2 == 0)
//     {
//         Console.WriteLine($"{count} ");
//     }
//     else count++;
// Console.WriteLine($"{count} ");

// Console.Write("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());

// int i = 0;

// for (i = 1; i <= N; i++)
// {
//     if (i % 2 == 0)
//     {
//         Console.Write(i);
//         i++;
//     }
// }

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

int i = 1;

while (i <= N)
{
    if (i % 2 == 0)
    {
        Console.Write($"{i} ");
    }
i++;   
}
