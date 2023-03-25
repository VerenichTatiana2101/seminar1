// Задача 43: Напишите программу, которая 
// найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double MetodX(double b1, double b2, double k1, double k2)
{
    double sysX = (b2 - b1) / (k1 - k2);
    return sysX;
}

double MetodY(double b1, double b2, double k1, double k2, double digitX)
{
    double sysY = k1 * digitX + b1;
    return sysY;
}

Console.WriteLine("Введите число b1: ");
double digitB1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число b2: ");
double digitB2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число k1: ");
double digitK1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число k2: ");
double digitK2 = Convert.ToInt32(Console.ReadLine());

double digitX = MetodX(digitB1, digitB2, digitK1, digitK2);
double digitY = MetodY(digitB1, digitB2, digitK1, digitK2, digitX);

if (digitK1 == digitK2)
    {
        Console.WriteLine($"Прямые не пересекаются"); 
    }
else 
Console.WriteLine($"Точки пересечения двух прямых -> ({digitX}; {digitY})");

