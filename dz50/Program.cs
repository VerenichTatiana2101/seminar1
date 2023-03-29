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
int numRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int numColumns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

bool arrayExistance = ArrayExistance(array2d, numRows, numColumns);

Console.WriteLine(arrayExistance ? $"{numRows}, {numColumns} -> такого числа нет в массиве"
                                 : $"{numRows}, {numColumns} -> {array2d[numRows - 1, numColumns - 1]}");

bool ArrayExistance(int[,] matrix, int rows, int columns)        //метод проверки введённых чисел, 
{                                                                //входят ли они в рамки массива
    if (rows > matrix.GetLength(0)
    || columns > matrix.GetLength(1)
    || rows <= 0 
    || columns <= 0)
    return true;
    else return false;
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

void PrintMatrix(int[,] matrix)                            //метод печати двумерного массива
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

