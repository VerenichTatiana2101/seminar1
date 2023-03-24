// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

string BinaryDigit(int digit)
{
    string result = string.Empty;
    while (digit > 0)
    {
        int a = digit % 2;
        digit = digit / 2;
        result = Convert.ToString(a) + result;
    }
    return result;
}

string rez = BinaryDigit(num);
Console.WriteLine(rez);

