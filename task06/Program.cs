// Задача 11.
// Написать программу, которая
// выводит случайное трёхзначное число и
// удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

// int number = new Random().Next(100,1000);
// Console.WriteLine($"Случайное трёхзначное число -> {number}"); //из отрезка 100-999

// int res = DelSecond(number);
// Console.WriteLine($"Первая и третья цифра трёхзначного числа {res}");

// int DelSecond(int num)
// {
//     int firstDigit = number / 100;
//     int thirtDigit = number % 10;
//     int res = firstDigit * 10 + thirtDigit;
//     return res;
// }

////
int number = new Random().Next(100,1000);
Console.WriteLine($"Случайное трёхзначное число -> {number}"); //из отрезка 100-999

int res = DelSecond(number);
Console.WriteLine($"Первая и третья цифра трёхзначного числа {res}");

int DelSecond(int num)
{
    return number / 100 * 10 + number % 10 ;
}
