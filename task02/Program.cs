// Написать программу, которая 
// будет выдавать название дня недели
// по заданному номеру.
// Например 3 -> среда
//          5 -> пятница

// Console.WriteLine("Введите целое число: ");
// string number = Console.ReadLine();

// if (number == "1")
// {
//     Console.Write($"День недели {number} - понедельник");
// }

// else if (number == "2")
// {
//     Console.Write($"День недели {number} - вторник");
// }

// else if (number == "3")
// {
//     Console.Write($"День недели {number} - среда");
// }

// else if (number == "4")
// {
//     Console.Write($"День недели {number} - четверг");
// }

// else if (number == "5")
// {
//     Console.Write($"День недели {number} - пятница");
// }

// else if (number == "6")
// {
//     Console.Write($"День недели {number} - суббота");
// }

// else if (number == "7")
// {
//     Console.Write($"День недели {number} - воскресенье");
// }

// else
// {
//     Console.Write($"Дня недени {number} - не существует, введите другое число");
// }

//В данном случает else if оптимизирует наше решение, 
//и если вариант подходит, 
//цикл останавливается и не идет дальше по кругу.

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 1)
{
    Console.Write($"День недели {number} - понедельник");
}

else if (number == 2)
{
    Console.Write($"День недели {number} - вторник");
}

else if (number == 3)
{
    Console.Write($"День недели {number} - среда");
}

else if (number == 4)
{
    Console.Write($"День недели {number} - четверг");
}

else if (number == 5)
{
    Console.Write($"День недели {number} - пятница");
}

else if (number == 6)
{
    Console.Write($"День недели {number} - суббота");
}

else if (number == 7)
{
    Console.Write($"День недели {number} - воскресенье");
}

else
{
    Console.Write($"Дня недени {number} - не существует, введите другое число");
}
