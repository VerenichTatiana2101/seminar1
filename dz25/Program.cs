Console.WriteLine("Введите целое  число 1: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое  число 2: ");
int degree = Convert.ToInt32(Console.ReadLine());

int degreeNumbers = DegreeNumber(number, degree);

Console.WriteLine($"Число {number} в степени {degree} -> {degreeNumbers}");

int DegreeNumber(int num, int degr)
{
    int num1 = num;
    for (int count = 2; count <= degr; count++)
    {
        num *= num1;   
    }
    return num;
}
