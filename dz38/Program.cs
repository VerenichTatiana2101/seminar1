﻿// Задача 38:
//  Задайте массив вещественных чисел. 
// Найдите разницу между максимальным 
// и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(num, 1);
    }
    return arr;
}

double MaxNumber(double[] array)
{
    double max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}

double MinNumber(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}

double DifferenceMaxMin(double max, double min)
{
    return max - min;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}; ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

double[] array = CreateArrayRndDouble(5, 1, 5);
PrintArray(array);
Console.WriteLine();

double max = MaxNumber(array);
MaxNumber(array);

double min = MinNumber(array);
MinNumber(array);

double difference = DifferenceMaxMin(max, min);
Console.WriteLine($"Разность максимального [{max}] и минимального [{min}] элементов -> {Math.Round(difference, 2)}");

