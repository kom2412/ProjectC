﻿// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("введите значение b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите значение k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите значение b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите значение k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double numX = 0;
double numY = 0;

if (b1 == b2 & k1 == k2) Console.WriteLine("Прямые совпадают.");
else if (k1 == k2) Console.WriteLine("Прямые параллельны друг другу.");
else
{
    numX = (b2 - b1) / (k1 - k2);
    numY = k1 * numX + b1;
    Console.WriteLine($"Точка пересечения двух прямых: {numX},{numY}");
}