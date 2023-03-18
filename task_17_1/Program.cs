// Задача 30. 
// Написать программу, которая
// выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.
// Например:
// [1, 0, 1, 1, 0, 1, 0, 0]



int[] arr = 

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
