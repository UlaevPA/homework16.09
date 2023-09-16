
    // Задача 56: Задайте прямоугольный двумерный массив.
    // Напишите программу, которая будет находить строку с наименьшей суммой элементов.

    // Например, задан массив:
    // 1 4 7 2
    // 5 9 2 3
    // 8 4 2 4
    // 5 2 6 7

    // Программа считает сумму элементов в каждой строке и 
    // выдаёт номер строки с наименьшей суммой элементов:1 строка

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine();
    }
}

int[] SumRowsMatrix(int[,] matrix)
{
    int rows = matrix.GetLength(1);
    int columns = matrix.GetLength(0);

    int[] sumRows = new int[columns];
    for (int i = 0; i < columns; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            sumRows[i] += matrix[i, j];
        }
    }
    return sumRows;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int FindMaxSum(int[] arr)
{
    int indexMax = 0;
    int max;
    for (int i = 1; i < arr.Length; i++)
    {
        max = arr[0];
        if (arr[i] > max)
        {
            max = arr[i];
            indexMax = i;
        }
    }
    return indexMax;
}


int[,] matrix = CreateMatrixRndInt(4, 3, 0, 10);
PrintMatrix(matrix);
Console.WriteLine();
Console.WriteLine("-------------------");

int[] sumRows = SumRowsMatrix(matrix);
PrintArray(sumRows);

int result = FindMaxSum(sumRows);

Console.WriteLine();
Console.WriteLine($"Maximum sum row #: {result}");
Console.WriteLine();