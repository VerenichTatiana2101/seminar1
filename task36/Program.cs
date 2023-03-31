// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.

(int, int) FindMinElement(int[,] matrix)
{
    int minValue = matrix[0,0];
    int minI = 0;
    int minJ = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                int element = matrix[i, j];
                if (element < minValue)
                {
                    minValue = element;
                    minI = i;
                    minJ = j;
                }
            }        
    }
    return (minI, minJ);
}

int[,] DropColumnAndRow(int minI, int minJ, int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    int[,] newMatrix = new int[rows - 1, columns - 1];
        for (int i = 0, newRow = 0; i < rows; i++)
        {
            if (i == minI)
            {
                continue;
            }

            for (int j = 0, newColumn = 0; j < columns; j++)
            {
                if (j == minJ)
                {
                    continue;
                }
                newMatrix[newRow, newColumn] = matrix[i, j];
                newColumn++;
            }
            newRow++;
        }
        return newMatrix;
}





// int[,] CreateMatrix(int rows, int columns, int min, int max)
// {
//     int[,] matrix = new int[rows, colums];

//     Random random = new Random();

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = random.Next(min, max + 1);
//         }
//     }

//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         Console.Write("|");
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j], 4} ");
//         }

//         Console.Write("|");
//         Console.WriteLine();

//     }
// }

// int[] CoordinatesMinimumValue(int[,] matrix)
// {
//     int minRow = 0;
//     int minColumn = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if(matrix[i,j] < matrix[minRow, minColumn])
//             {
//                 minRow = i;
//                 minColumn = j;
//             }
//         }
//     }
//     return new int[]{minRow, minColumn};
// }


// int[,] NewMatrix(int[,] matrix, int[] coords)
// {
//     int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1)- 1];
//     for (int i = 0, newRow = 0; i < matrix.GetLength(0); i++)
//     {
//         if(i == coords[0]) continue;
//         {
//             for (int j = 0, newColumn = 0; j < matrix.GetLength(1); j++)
//             {
                
//             }
//         }
//     }
// }
