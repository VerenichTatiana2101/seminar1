// Задача 60.Сформируйте трёхмерный массив 
// из неповторяющихся двузначных чисел. Напишите 
// программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

Console.Write("Введите количество строчек массива: ");
int matrixRows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int matrixColumns = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите размер глубины массива: ");
int matrixDepth = Convert.ToInt32(Console.ReadLine());

int[,,] array3d = CreateMatrix3DRndInt(matrixRows, matrixColumns, matrixDepth, 10, 99);

if (CorrespondingArray(array3d, matrixRows, matrixColumns, matrixDepth))
{
    PrintMatrix(array3d);
}
else Console.WriteLine("Данные параметры не подходят для заполнения трёхмерного массива неповторяющимися двузначными числами");

bool CorrespondingArray(int[,,] matrix, int rows, int columns, int depth)
{
    return rows > 1
    && columns > 1
    && depth > 1
    && rows * columns * depth <= 99;
}

int[,,] CreateMatrix3DRndInt(int rows, int columns, int depth, int min, int max)  //создание рандомного трёхмерного массива
{                          // 0       1
    int[,,] matrix = new int[rows, columns, depth];
    int num = min;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = num;
                num++;
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)                             //метод печати трёхмерного массива построчно с индексами
{
    int p = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            // Console.WriteLine();
            for (int k = 0; k < matrix.GetLength(2); k++)
                Console.Write($"{matrix[i, j, k],4}({i},{j},{k}) ");
        }
        p++;
        Console.WriteLine();
        // Console.WriteLine($"page {p}");
    }
}



