// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите целое  число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sumNumbers = SumNumbers(number);
Console.WriteLine($"количество цифр в числе {number} -> {sumNumbers}");

int SumNumbers(int num)
{
    int count = 0;
    while (num != 0)
    {
        count++;
        num/=10;
    }
    return count;
}