// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] numbers = new int[4];
RandomNumbers(numbers);
PrintArray(numbers);
int sumNumbers = 0;
for (int i = 1; i < numbers.Length; i += 2)
{
    sumNumbers += numbers[i];
}
Console.Write(sumNumbers);
void RandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 99);
    }
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}