// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5     7  -2  -0,2
//   1  -3,3   8  -9,9
//   8   7,8  -7,  1 9

Console.Write("Введите количество строк двумерного массива: ");
int matrixRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов двумерного массива: ");
int matrixColumns = Convert.ToInt32(Console.ReadLine());

// if (matrixRows <2 || matrixColumns < 2)
// {
//     Console.WriteLine("Такого двумерного массива не существует, либо массив не является двумерным");
//     Console.WriteLine("Повторите команду, используя другие параметры");
//     return;
// }

double[,] array2d = CreateMatrixRndInt(matrixRows, matrixColumns, -50, 100);
PrintMatrix(array2d);

double[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{                          // 0       1
    double[,] matrix = new double[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.NextDouble() * (max - min) + min;
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            double roundingNumbers = Math.Round(matrix[i, j], 1);
            Console.Write($"{roundingNumbers,6} ");
        }
        Console.WriteLine("|");
    }
}


