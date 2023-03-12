// Задача 10: Напишите программу, которая принимает 
// на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num >= 100 && num < 1000)
{
    int twoDigit = num / 10;
    int numSecond = twoDigit % 10;
    Console.WriteLine($"Вторая цифра числа {num} - {numSecond}");
}

else
{
    Console.WriteLine("Данное число не является трёхзначным");
}


// Console.Write("Введите трёхзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int result = NumSecond(num);

// if (num >= 100 && num < 1000 || num < -99 && num > -1000)
// {

//     Console.WriteLine($"Вторая цифра числа -> {result}");
// }

// else
// {
//     Console.WriteLine("Данное число не является трёхзначным");
// }

// int NumSecond(int number)
// {
//     if (num < 0)
//     {
//         num = num * -1;
//     }
//     return num / 10 % 10;
// }

