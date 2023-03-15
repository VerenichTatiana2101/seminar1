// Задача 19
// Напишите программу, которая 
// принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций 
// (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool rezult = Polidrom(number);

if (number > 1000 && number < 100000)
{
    Console.WriteLine(rezult ? "Да" : "Нет");
}
else
    Console.WriteLine($"Число не пятизначное");

bool Polidrom(int revers)
{
    if (number < 0) number = number * -1;
    if (number == Revers(number))
        return true;
    return false;
}

int Revers(int num)
{
    return num % 10 * 10000
    + (num / 10) % 10 * 1000
    + (num / 100) % 10 * 100
    + (num / 1000) % 10 * 10
    + (num / 10000);
}
