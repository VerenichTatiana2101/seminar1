// Задача 29: Напишите программу, которая 
// задаёт массив из 8 элементов и 
// выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

// Console.Write("Введите размер массива: ");
// int arraySize = Convert.ToInt32(Console.ReadLine());

// if (arraySize <= 0)
// {
//     Console.WriteLine($"Ошибка: введено неверное значение {arraySize}");
//     return; 
// }

// int[] arr = FillArray(arraySize);
// PrintArray(arr);

// int[] FillArray(int arrayLength)
// {
//     int[] newArray = new int[arrayLength];
//     Random random = new Random();
//     for (int i = 0; i < arrayLength; i++)
//     {
//         newArray[i] = random.Next(1, 100);
//     }
//     return newArray;
// }

// void PrintArray(int[] array)
// {
//     int i = 0;
//     Console.Write("[");
//     while (i < array.Length)
//     {
//         Console.Write(array[i]);
//         i++;
//         if (i < array.Length)
//         {
//             Console.Write(", ");
//         }
//     }
//     Console.Write("]");
// }

int[] arr = new int[8];

FillArray(arr);
PrintArray(arr);

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Random random = new Random(); 
        array[i] = random.Next(1, 100);
    }
}

void PrintArray(int[] array)
{
    int i = 0;
    Console.Write("[");
    while (i < array.Length)
    {
        Console.Write(array[i]);
        i++;
        if (i < array.Length)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}