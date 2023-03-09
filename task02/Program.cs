// Написать программу, которая 
// будет выдавать название дня недели
// по заданному номеру.
// Например 3 -> среда
//          5 -> пятница

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 1)
{
    Console.Write($"День недели {number} - понедельник");
}

if (number == 2)
{
    Console.Write($"День недели {number} - вторник");
}

if (number == 3)
{
    Console.Write($"День недели {number} - среда");
}

if (number == 4)
{
    Console.Write($"День недели {number} - четверг");
}

if (number == 5)
{
    Console.Write($"День недели {number} - пятница");
}

if (number == 6)
{
    Console.Write($"День недели {number} - суббота");
}

if (number == 7)
{
    Console.Write($"День недели {number} - воскресенье");
}

else
{
    Console.Write($"Дня недени {number} - не существует, введите другое число");
}
