// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа 
// в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите целое натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (NaturalNumberCheck(number))
{
    NaturalNumbers(number);
}
else Console.WriteLine("Введённое число не является натуральним или равно нулю");

bool NaturalNumberCheck(int num)
{
    return num > 0;
}

void NaturalNumbers(int num)
{
    if(num == 0) return;   
    Console.Write($"{num} ");  //выводит в обратном порядке, если консоль поставить д нат нум будет с 5 до 1(стек не использ)
    NaturalNumbers(num - 1);
}