﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int num = number % 2;

if(num == 0)
    {
    Console.WriteLine("Да");
    }
else
    {
    Console.WriteLine("Нет");
    }