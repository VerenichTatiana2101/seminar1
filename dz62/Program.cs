// Задача 62. Напишите программу, которая 
// заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] array2d = CreateMatrixRndInt(4, 4);
PrintMatrix(array2d);

int[,] CreateMatrixRndInt(int rows, int columns)
{                          // 0       1
    int[,] matrix = new int[rows, columns];
    int i = 0;
    int j = 0;
    int num = 1;
    while (num <= matrix.Length)
    {
        matrix[i, j] = num;
        num++;
        if (i <= j + 1 && i + j < matrix.GetLength(1) - 1)
        {
            j++;
        }
        else if (i < j && i + j >= matrix.GetLength(0) - 1)
        {
            i++;
        }
        else if (j <= i && i + j > matrix.GetLength(1) - 1)
        {
            j--;
        }
        else i--;
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