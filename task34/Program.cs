// Задача 55.
// Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае,
// когда это невозможно, программа должна 
// вывести сообщение для пользователя.

int[,] array2d = CreateMatrixRndInt(5, 4, -10, 10);
PrintMatrix(array2d);
Console.WriteLine();

if (SuitableValues(array2d))
{
    RowsRaplacingColumns(array2d);
    PrintMatrix(array2d);
}
else Console.WriteLine("Для замены необходимо равное количество строчек и столбцов");

bool SuitableValues(int[,] matrix)
{
    return matrix.GetLength(0) == matrix.GetLength(1);
}

void RowsRaplacingColumns(int[,] matrix)             //метод замены строчек столбцами
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < i; j++)
        {
            int temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;
        }
    }
}

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{                          // 0       1
    int[,] matrix = new int[rows, columns];
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

void PrintMatrix(int[,] matrix)
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
