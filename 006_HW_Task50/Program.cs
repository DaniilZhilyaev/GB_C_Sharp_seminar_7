/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

позиция i = 4, j = 2 -> такой позиции нет
позиция i = 1, j = 0 -> 5 */

int rows = new Random().Next(2, 5);
int columns = new Random().Next(2, 5);
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

Console.WriteLine("Введите индекс строчки: ");
int line = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите индекс столбца: ");
int pillar = int.Parse(Console.ReadLine()!);

SearchArray(array, line, pillar);

// Поиск элемента массива
void SearchArray(int[,] array, int line, int pillar)
{
    bool search = false;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == line && j == pillar) search = true;
        }
    }
    if (search == true) Console.WriteLine($"Искомый элемент: {array[line, pillar]}");
    else Console.WriteLine("Элемент не существует");
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