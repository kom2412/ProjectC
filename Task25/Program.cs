﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

int exp = A;

for (int i = 1; i < B; i++)
{
    exp = exp * A;
}
Console.WriteLine("А в степени В = " + exp);