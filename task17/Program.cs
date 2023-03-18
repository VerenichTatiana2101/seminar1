// Задача 30. 
// Написать программу, которая
// выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.
// Например:
// [1, 0, 1, 1, 0, 1, 0, 0]


//массив заполняется нулями   
// int[] arr = new int[8]; ---задаём длину массива, сколько памяти выделить под массив (4*8)байт
// int[] arr = {1,2 }; можно сразу заполнить массив
//array[3] = 34; можно в индекс 3 числа вписать значение   

int[] arr = new int[8];

FillArray(arr);
PrintArray(arr);

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Random random = new Random();  //делается с отдельной переменной.
        array[i] = random.Next(0, 2);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " "); //чтобы сделать пробелы между числами в массиве
    }
}

//вариант2

// Console.Write("Введите размер массива: ");

// int arraySize = Convert.ToInt32(Console.ReadLine());

// if (arraySize <= 0)
// {
//     Console.WriteLine($"Ошибка: введено неверное значение {arraySize}");
//     return;    //возвращает нас в начало
// }

// int[] arr = CreateArray(arraySize);
// PrintArray(arr);
// int[] CreateArray(int arrayLength)
// {
//     int[] newArray = new int[arrayLength];
//     Random random = new Random();
//     for (int i = 0; i < arrayLength; i++)
//     {
//         newArray[i] = random.Next(0, 2);
//     }
//     return newArray;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " "); //чтобы сделать пробелы между числами в массиве
//     }
// }
