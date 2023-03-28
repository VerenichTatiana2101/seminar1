// Задача 50. Напишите программу, которая на вход 
// принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет

int[,] array2d = CreateMatrixRndInt(4, 5, -10, 10);
PrintMatrix(array2d);

Console.Write("Введите номер строки: ");
int numberRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int numberColumns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int result = ElementMatrix(array2d, numberRows, numberColumns);

if (numberRows > array2d.GetLength(0) || numberColumns > array2d.GetLength(1))
{
    Console.WriteLine($"{numberRows}, {numberColumns} -> такого числа нет в массиве");
}
else 
{
    Console.WriteLine($"{numberRows}, {numberColumns} -> {result}");
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

int ElementMatrix(int[,] matrix, int numRows, int numColumns)
{
    return matrix[numRows - 1, numColumns - 1];
}

