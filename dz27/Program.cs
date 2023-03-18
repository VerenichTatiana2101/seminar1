// Задача 27: Напишите программу, которая 
// принимает на вход число и 
// выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите целое  число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sumNumbers = SumNumbers(number);
Console.WriteLine($"сумма цифр числа {number} -> {sumNumbers}");

int SumNumbers(int num)
{
    int temp = 0;
    int sum = 0;
    if (num < 0) num *= -1;    
    while (num != 0) 
    {
        temp = num % 10;
        num = num / 10;
        sum = sum + temp;
    }
    return sum; 
}
