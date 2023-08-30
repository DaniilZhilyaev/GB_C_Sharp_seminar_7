/* **Задача 48:** Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: A(I,j) = i+j. Выведите полученный массив на экран.

m = 3, n = 4.

0 1 2 3

1 2 3 4

2 3 4 5 */

Console.WriteLine("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);


Console.WriteLine("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns);
PrintArray(array);

// Создание массива

int[,] GetArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = i + j;
        }
    }
    return array;
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