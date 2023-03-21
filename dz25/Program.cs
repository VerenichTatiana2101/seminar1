// Задача 25: Напишите цикл, который 
// принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Promp(string massage)
{
    System.Console.Write(massage); //выводим приглашение ко вводу
    string readInput = System.Console.ReadLine(); //вводим значение
    int result = int.Parse(readInput); //приводим к числу
    return result;   //возвращаем результат
}

int DegreeNumber(int numFix, int degree)
{
    int res = 1;
    for (int i = 0; i != degree; i++)
    {
        checked
        {
            res *= numFix;
        }
    }
    return res;
}

bool ValidateDegreeNumber(int degree)
{
    if (degree < 0)
    {
        System.Console.WriteLine("Показатель не должен быть меньше нуля");
        return false;
    }
    return true;
}

int numFix = Promp("Введите целое число: ");
int degree = Promp("Введите натуральную степень числа: ");

if (ValidateDegreeNumber(degree))
{
    System.Console.WriteLine($"Число {numFix} в степени {degree} -> {DegreeNumber(numFix, degree)}");
}