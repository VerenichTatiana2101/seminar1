﻿// Задача 23
// Напишите программу, которая 
// принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

Console.WriteLine("Введите натуральное число: ");
int num = Convert.ToInt32(Console.ReadLine());

TableCube(num);

void TableCube(int number)
{
  int count = 1;
  while (count <= number)
  {
    int cubeNumber = count * count * count;
    Console.WriteLine($"{count, 3} -> {cubeNumber, 5}");
    count++;
  }
  

}
