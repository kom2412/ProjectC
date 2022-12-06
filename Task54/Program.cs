// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int m = 3;
int n = 4;

int[,] num = new int[m, n];
ArrayNum(num);

Console.WriteLine("\nМассив до изменения:");
PrintArray(num);

for (int i = 0; i < num.GetLength(0); i++)
{
    for (int j = 0; j < num.GetLength(1) - 1; j++)
    {
        for (int z = 0; z < num.GetLength(1) - 1; z++)
        {
            if (num[i, z] < num[i, z + 1]) 
            {
                int temp = 0;
                temp = num[i, z];
                num[i, z] = num[i, z + 1];
                num[i, z + 1] = temp;
            }
        }
    }
}
Console.WriteLine("\nМассив с упорядоченными значениями:");
PrintArray(num);

void ArrayNum(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
