// Задача 15: Напишите программу, которая 
// принимает на вход цифру, 
// обозначающую день недели, и 
// проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

// if (number == 1)
// {
//     Console.Write($"День недели {number} - нет");
// }

// else if (number == 2)
// {
//     Console.Write($"День недели {number} - нет");
// }

// else if (number == 3)
// {
//     Console.Write($"День недели {number} - нет");
// }

// else if (number == 4)
// {
//     Console.Write($"День недели {number} - нет");
// }

// else if (number == 5)
// {
//     Console.Write($"День недели {number} - нет");
// }

// else if (number == 6)
// {
//     Console.Write($"День недели {number} - да");
// }

// else if (number == 7)
// {
//     Console.Write($"День недели {number} - да");
// }

// else
// {
//     Console.Write($"Дня недени {number} - не существует, введите другое число");
// }

if (number < 8 && number > 0)
{
    if (number < 6)
    {
        Console.Write($"День недели {number} - нет");
    }
    if (number > 5)
        Console.Write($"День недели {number} - да");
}
else
    Console.Write($"Дня недени {number} - не существует, введите другое число");



