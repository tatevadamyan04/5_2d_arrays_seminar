//Задача 3: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
int[,] array = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9},
            {10, 11, 12}
        };

Console.WriteLine("Original Array:");
PrintArray(array);

int minSumRowIndex = FindRowWithMinSum(array);

Console.WriteLine($"\nRow with the smallest sum is: {minSumRowIndex + 1} (1-based index)");

static int FindRowWithMinSum(int[,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);

    int minSum = int.MaxValue;
    int minSumRowIndex = -1;

    for (int row = 0; row < rows; row++)
    {
        int rowSum = 0;

        for (int col = 0; col < cols; col++)
            rowSum += array[row, col];


        if (rowSum < minSum)
        {
            minSum = rowSum;
            minSumRowIndex = row;
        }
    }

    return minSumRowIndex;
}

static void PrintArray(int[,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);

    for (int row = 0; row < rows; row++)
    {
        for (int col = 0; col < cols; col++)
            Console.Write($"{array[row, col]} ");
        Console.WriteLine();
    }
}