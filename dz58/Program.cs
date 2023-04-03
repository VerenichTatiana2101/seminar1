// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Созданный массив1: ");
int[,] array2d = CreateMatrixRndInt(5, 2, 1, 10);
PrintMatrix(array2d);
Console.WriteLine();

Console.WriteLine("Созданный массив2: ");
int[,] array2d2 = CreateMatrixRndInt(2, 5, 1, 10);
PrintMatrix(array2d2);
Console.WriteLine();

int[,] result = MultiplicationMatrix(array2d, array2d2);
Console.WriteLine($"Результатирующая матрица: {result}");

int[,] MultiplicationMatrix(int[,] matrix1, int[,] matrix2)       //метод умножения матриц
{
    int[,] res = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                {
                    res[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }
    }
    return res;
}

if (CorrespondingArray(array2d, array2d2))
{
    PrintMatrix(result);
}
else Console.WriteLine("Матрицу 1 нельзя умножить на матрицу 2");

bool CorrespondingArray(int[,] matrix1, int[,] matrix2)
{
    return matrix1.GetLength(0) == matrix2.GetLength(1);
}

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
