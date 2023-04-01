// Задача 54: Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.WriteLine("Созданный массив: ");
int[,] array2d = CreateMatrixRndInt(5, 5, -10, 10);
PrintMatrix(array2d);
Console.WriteLine();
Console.WriteLine("Отсортированный массив по убыванию построчно вариант 1: ");
SortRowsNumbers(array2d);
PrintMatrix(array2d);

Console.WriteLine("Отсортированный массив по убыванию построчно вариант 2: ");
SortRowsNumbers2(array2d);
PrintMatrix(array2d);

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

void SortRowsNumbers(int[,] matrix)      //метод сортировки по строкам от большего к меньшему
{
    int k = 0;
    int temp = 0;
    while (k < matrix.GetLength(1))
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] < matrix[i, k])
                {
                    temp = matrix[i, k];
                    matrix[i, k] = matrix[i, j];
                    matrix[i, j] = temp;
                }
            }
        }
        k++;
    }  
}

void SortRowsNumbers2(int[,] matrix)           //метод сортировки по строкам от большего к меньшему
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1) - 1; k++)
            {
                if (matrix[i, k] < matrix[i, k + 1])
                {
                    int temp = matrix[i, k + 1];
                    matrix[i, k + 1] = matrix[i, k];
                    matrix[i, k] = temp;
                }
            }
        }
    }
}



