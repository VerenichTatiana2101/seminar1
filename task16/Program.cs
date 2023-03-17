// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите целое  число: ");
int number = Convert.ToInt32(Console.ReadLine());

int factNumbers = FactNumbers(number);
Console.WriteLine($"сумма чисел от 1 до {number} -> {factNumbers}");

int FactNumbers(int num)
{
    int product = 1;
    for (int count = 2; count <= num; count++)
    {
        checked
        {
            product = product * count;
        }

    }
    return product;
}

