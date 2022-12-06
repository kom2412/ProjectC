// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int m = 4;
int n = 4;
int[,] num = new int[m, n];
ArrayNum(num);
PrintArray(num);
void ArrayNum(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
        }
    }
}
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Среднее арифметическое столбцов массива =");
for (int j = 0; j < num.GetLength(1); j++)
{
    double aver = 0;
    for (int i = 0; i < num.GetLength(0); i++)
    {
        aver = (aver + num[i, j]);
    }
    aver = aver / m;
    Console.Write(aver + "\t");
}