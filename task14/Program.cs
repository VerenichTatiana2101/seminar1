// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Clear();   //очистить консоль

Console.WriteLine("Введите целое  число: ");
int number = Convert.ToInt32(Console.ReadLine());

int countDigit = CountDigit(number);
Console.WriteLine($"количество цифр в числе {number} -> {countDigit}");

int CountDigit(int num)
{
    int count = 0;    //в цикле while счётчик используется count
    while (num != 0) //пока число не равно 0
    {
        count++; // фиксируем значение войдя в цикл
        num/=10;
    }
    return count;  //считаем кол-во интераций, столько цифр 
}

