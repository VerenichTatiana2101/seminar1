// Задача 16.
// Написать программу, которая принимает на
// вход два числа и проверяет, является ли 
// одно число квадратом другого. Например:
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> нет
// 8, 9 -> нет

Console.WriteLine("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

bool result = Square(number1, number2);

Console.WriteLine(result ? "Да" : "Нет");

bool Square(int num1, int num2)
{
return num1 * num1 == num2 || num2 * num2 == num1;
}
