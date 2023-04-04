// Задача 55.
// Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае,
// когда это невозможно, программа должна 
// вывести сообщение для пользователя.
//Вариант2

Console.Write("Введите количество строк:");           //можно сделать, чтобы пользователь вводил только одно число
int row = Convert.ToInt32(Console.ReadLine());        //т.к матрица равносторонняя
Console.Write("Введите количество столбцов:");        
int colum = Convert.ToInt32(Console.ReadLine());

if (Verification(row, colum))
{
    Console.Write("Введены неверные данные");
    return;
}
int[,] array2d = SquareCreateMatrix(row, -10, 10);
int[,] newArray2d = ChangeColumsRows(array2d);
PrintMatrix(array2d);
Console.WriteLine("Новый массив");
PrintMatrix(newArray2d);
Console.WriteLine("Изменённый старый");
ChangeColumsRowsOneMatrix(array2d);
PrintMatrix(array2d);

int[,] SquareCreateMatrix(int rows, int min, int max)  //метод квадратной матрицы
{
    int[,] matrix = new int[rows, rows];            //по одному размеру, т.к строки равны столбикам
    Random random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.Next(min, max + 1);
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
        Console.Write("|");
        Console.WriteLine();
    }
}

bool Verification(int rows, int colums)
{
    return rows != colums || rows < 0 || colums < 0;         //если пользователь будет вводить одно число проверку 
}                                                            //равны ли стороны делать не нужно

int[,] ChangeColumsRows(int[,] matrix)
{                                                            //метод с  созданием новой матрицы
    int size = matrix.GetLength(0);
    int[,] newMatrix = new int[size, size];            //по одному размеру, т.к строки равны столбикам
    for (int i = 0; i < size; i++)                      //чтобы не повторять гетленс создали переменную
    {
        for (int j = 0; j < size; j++)
        {
            newMatrix[j, i] = matrix[i, j];       //перекладываем значения из старого массива в новый меняя положения из строки в столбец
        }                                          //newMatrix[i, j] = matrix[j, i]; в данном случае без разницы
    }                                                //метод медленнее
    return newMatrix;
}

void ChangeColumsRowsOneMatrix(int[,] matrix)            //метод через while, впринципе нет необходимости, лучше for 
{                                                         //удобнее
    int temp = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int j = i + 1;
        while (j < matrix.GetLength(0))
        {
            temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;
            j++;
        }
    }
}

void ChangeColumsAndRows(int[,] matrix)          //проход по верхнему левому углу не затрагивая середину
{
    int size = matrix.GetLength(0);
    for (int i = 0; i < size - 1; i++)
    {
        for (int j = i + 1; j < size; j++)
        {
            int temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;
        }
    }
}


