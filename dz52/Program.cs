// Задача 52. 
// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 
// 4,6; 5,6; 3,6; 3.

int[,] array2d = CreateMatrixRndInt(4, 5, -10, 10);
PrintMatrix(array2d);

Console.WriteLine($"Среднее арифметическое каждого столбца: ");
double[] result = AverageColumns(array2d);
PrintArray(result);

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{                          // 0       1
    int[,] matrix = new int[rows, columns];                     //метод создания двумерного массива со случайными числами
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)                                //метод печати двумерного массива
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}

double[] AverageColumns(int[,] matrix)                        //метод вычисления среднего арифметическое каждого столбца
{
    double[] averege = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            averege[j] += matrix[i, j];
        }
        averege[j] /= matrix.GetLength(0);
    }
    return averege;
}

void PrintArray(double[] averege)                              //метод печати одномерного массива из 
{                                                              //вещественных чисел с округлением до 2 цифр после запятой
    Console.Write("[");
    for (int i = 0; i < averege.Length; i++)
    {
        if (i < averege.Length - 1) Console.Write(Math.Round(averege[i], 2) + "; ");
        else Console.Write(Math.Round(averege[i], 2));
    }
    Console.Write("]");
}
