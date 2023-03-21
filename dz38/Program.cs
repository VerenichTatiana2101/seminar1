// Задача 38:
//  Задайте массив вещественных чисел. 
// Найдите разницу между максимальным 
// и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

int[] arr = {12, 1, 17, 36, 95, 13, 12};

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int SelectionSort(int[] array)
{
    int max = 0;
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        else if (array[i] < min) min = array[i];
    }
    int res = max - min;
    return res;
}



PrintArray(arr);
SelectionSort(arr);

Console.WriteLine($"разницу между максимальным и минимальным элементов массива -> {SelectionSort(arr)} ");



// double[] CreateArrayRndDouble(int size, int min, int max)
// {
//     double[] arr = new double[size];
//     Random rnd = new Random();

//     for (int i = 0; i < arr.Length; i++)
//     {
//         double num = rnd.NextDouble() * (max - min) + min;
//         arr[i] = Math.Round(num, 1);
//     }
//     return arr;
// }



// void PrintArray(int[] arr)
// {
//     Console.WriteLine("{0}", string.Join(", ", arr));
//     Console.WriteLine();
// }