/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

int rows = new Random().Next(2, 5);
int columns = new Random().Next(2, 5);
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

double[] arr = AverageArifmetic(array);
Console.WriteLine($"[{String.Join(", ", arr)}]");

// Вычисление среднего арифмитического в столбцах массива

double[] AverageArifmetic(int[,] array)
{
    double[] result = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double average = 0;
        double summ = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            summ = summ + array[i, j];
        }
         average = summ / array.GetLength(0);
         result[j] = average;
    }
    return result;
}

// Создание массива
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] res = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            res[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return res;
}

// Печать массива
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}