// Задача 56: 
// Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет
// находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] array2d = CreateMatrixRndInt(4, 5, -10, 10);
PrintMatrix(array2d);

Console.WriteLine($"Суммы каждой строчки: ");
int[] result = SumRowsNumbers(array2d);
PrintArray(result);

int min = MinNumber(result);
Console.WriteLine();
Console.WriteLine($"Номер строки с наименьшей суммой строк массива -> {min}");

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

int[] SumRowsNumbers(int[,] matrix)                        //метод вычисления среднего арифметическое каждого столбца
{
    int[] sumNumbers = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumNumbers[i] += matrix[i, j];
        }
    }
    return sumNumbers;
}

void PrintArray(int[] sumNumbers)
{
    Console.Write("[");
    for (int i = 0; i < sumNumbers.Length; i++)
    {
        if (i < sumNumbers.Length - 1) Console.Write($"{sumNumbers[i]}; ");
        else Console.Write($"{sumNumbers[i]}");
    }
    Console.Write("]");
}

int MinNumber(int[] sumNumbers)        //метод поиска номера позиции с минимальным значением
{
    int min = sumNumbers[0];
    int maxNumberIndex = 0;
    for(int i = 0; i < sumNumbers.Length; i++)
    {
        if (sumNumbers[i] < min)
        {
            min = sumNumbers[i];
            maxNumberIndex = i;
        }
    }
    return maxNumberIndex + 1;
}
