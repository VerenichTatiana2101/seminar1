// Задача 25: Напишите цикл, который 
// принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень числа: ");
int degree = Convert.ToInt32(Console.ReadLine());

int degreeNumber = DegreeNumber(number, degree);
Console.WriteLine($"Число {number} в степени {degree} -> {degreeNumber}");

int DegreeNumber(int num, int degr)
{
    int numFix = num;
    for (int i = 2; i <= degr; i++)
    {
        checked
        {
            num *= numFix;
        }

    }
    return num;
}
