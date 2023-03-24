// Задача 41: Пользователь вводит 
// с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Write("Введите размер массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());

if (arraySize <= 0)
{
    Console.WriteLine($"Ошибка: введено неверное значение {arraySize}");
    return;
}

int[] array = FillArray(arraySize);
PrintArray(array);

int positivNumbers = PositivArrayNumbers(array);
Console.WriteLine($" -> {positivNumbers}");

int[] FillArray(int arrLength)
{
    int[] arr = new int[arrLength];
    for (int i = 0; i < arrLength; i++)
    {
        Console.Write("Введите число в массив: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());    
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int PositivArrayNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}