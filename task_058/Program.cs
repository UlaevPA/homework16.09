
    // Задача 58: Задайте две матрицы. 
    // Напишите программу, которая будет находить произведение двух матриц.
    // Например, даны 2 матрицы:
    // 2 4 | 3 4
    // 3 2 | 3 3
    // Результирующая матрица будет:
    // 18 20
    // 15 18

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


int[,] CreateMultiplicationMatrix(int[,] matrixLeft, int[,] matrixRight)
{
    int rowsLeftMatrix = matrixLeft.GetLength(0);
    int columnsLeftMatrix = matrixLeft.GetLength(1);

    int rowsRightMatrix = matrixRight.GetLength(0);
    int columnsRightMatrix = matrixRight.GetLength(1);

    int multiRows = rowsLeftMatrix < rowsRightMatrix ? rowsLeftMatrix : rowsRightMatrix;
    int multiColumns = columnsLeftMatrix < columnsRightMatrix ? columnsLeftMatrix : columnsRightMatrix;

    int[,] matrixMult = new int[multiRows, multiColumns];


    for (int i = 0; i < multiRows; i++)
    {
        for (int j = 0; j < multiRows; j++)
        {
            matrixMult[i, j] = 0;
            for (int k = 0; k < multiRows; k++)
            {
                matrixMult[i, j] += matrixLeft[i, k] * matrixRight[k, j];
            }
        }
    }
    return matrixMult;
}


int[,] matrixOne = CreateMatrixRndInt(2, 2, 1, 4);
PrintMatrix(matrixOne);
Console.WriteLine();


int[,] matrixTwo = CreateMatrixRndInt(2, 2, 1, 4);
PrintMatrix(matrixTwo);
Console.WriteLine();

int[,] testArray2D = CreateMultiplicationMatrix(matrixOne, matrixTwo);

Console.WriteLine();

PrintMatrix(testArray2D);