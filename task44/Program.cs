// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов 
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Вводим первое число:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вводим второе число:");
int n = Convert.ToInt32(Console.ReadLine());

// NaturalNumsRange(m, n);
int res = NaturalNumsRange(m, n);
// Console.WriteLine($"{res}");

if (NaturalNumberCheck(m, n))
{
    Console.WriteLine($"{res}");
}
else Console.WriteLine("Введённое число не является натуральним или"
                       + " сумму натуральных элементов в промежутке от M до N найти нельзя");

bool NaturalNumberCheck(int num1, int num2)
{
    return num1 != num2
        && num1 > 0 
        && num2 > 0;
}

int NaturalNumsRange(int num1, int num2)
{
    if (num1 == num2) return num1;
    else if (num1 < num2) return (num1 + NaturalNumsRange(num1 + 1, num2));
    else return (num1 + NaturalNumsRange(num1 - 1, num2));
}


