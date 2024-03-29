﻿// Задача 43: Напишите программу, которая 
// найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;      //y = 5x+2  y= 9x+4
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

const int COEFFICIENT = 0;
const int CONSTANT = 1;   //что это?? почему все с большой буквы?
const int X_COORD = 0;
const int Y_COORD = 1;
const int LINE1 = 1;
const int LINE2 = 2;

double[] lineData1 = InputLineData(LINE1);
double[] lineData2 = InputLineData(LINE2);

if (ValidateLines(lineData1, lineData2))
{
    double[] coord = FindCoords(lineData1, lineData2);
    Console.Write($"Точка пересечения уравнений y={lineData1[COEFFICIENT]}*x+{lineData1[CONSTANT]} и y={lineData2[COEFFICIENT]}*x+{lineData2[CONSTANT]} ");
    Console.WriteLine($" имеет координаты ({coord[X_COORD]}, {coord[Y_COORD]})");   //нет округления
}

double Promp(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    double result = Convert.ToInt32(value);
    return result;
}

double[] InputLineData(int numberOfLine)
{
    double[] lineData = new double[2];
    lineData[COEFFICIENT] = Promp($"Введите коэффициент для {numberOfLine} прямой >");
    lineData[CONSTANT] = Promp($"Введите константу для {numberOfLine} прямой >");
    return lineData;
}

double[] FindCoords(double[] lineData1, double[] lineData2)
{
    double[] coord = new double[2];
    coord[X_COORD] = (lineData1[CONSTANT] - lineData2[CONSTANT]) / ((lineData2[COEFFICIENT]) - lineData1[COEFFICIENT]);
    coord[Y_COORD] = lineData1[CONSTANT] * coord[X_COORD] + lineData1[CONSTANT];   //выше в выводе результата коэф2*х + конст2 тогда работает прав
    return coord;
}

bool ValidateLines(double[] lineData1, double[] lineData2)
{
    if (lineData1[COEFFICIENT] == lineData2[COEFFICIENT])
    {
        if (lineData1[CONSTANT] == lineData2[CONSTANT])
        {
            Console.WriteLine("Прямые совпадают");  //необходимо ли это, ведь не трубует условие
            return false;
        }
        else
        {
            Console.WriteLine("Прямые параллельны");
            return false;
        }
    }
    return true;
}    //неверный результат