// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите целое  число: ");
int number = Convert.ToInt32(Console.ReadLine());

int factorial = Factorial(number);
Console.WriteLine($"сумма чисел от 1 до {number} -> {factorial}");

int Factorial(int num)                  // в while счётчик используется count
{                                        // тут, в цикле for используется счётчик i
    int product = 1;                     //i = 2, убираем лишнюю интерацию, хоть и работает с 1
    for (int i = 2; i <= num; i++)  
    {                               
        checked                       //добавляем, чтобы программа выдавала ошибку при переполнении типа
        {                              //в данном случае, это лучше неверного резельтата
            product = product * i;
        }
    }
    return product;
}

//ещё сделать проверку на натуральность чисел

