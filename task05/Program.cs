// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 100);
Console.WriteLine($"случайное число из отрезка 10-99 -> {number}");    //получение числа

// int firstDigit = number / 10;
// int secondDigit = number % 10;
// if (firstDigit > secondDigit)
//     Console.WriteLine($"Наибольшая цифра сисла -> {firstDigit}");
// else
//     Console.WriteLine($"Наибольшая цифра сисла -> {secondDigit}");

// ///////////////////////////////
// int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;     //тернарный оператор
// Console.WriteLine($"Наибольшая цифра числа -> {maxDigit}");
// ///////////////////////////////
int result = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа -> {result}");    //метод

// int result1 = MaxDigit(68);    //можно одновременно с той же функцией вызывать несколько чисел и с набором вручную
// Console.WriteLine($"Наибольшая цифра числа -> {result1}");

int MaxDigit(int num)

{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
    return maxDigit;
}


