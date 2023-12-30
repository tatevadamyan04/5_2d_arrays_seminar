//Задача 4*(не обязательная): Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива. Под удалением понимается создание нового двумерного массива без строки и столбца.
int[,] array = {
            {5, 8, 2},
            {3, 0, 1},
            {7, 9, 4}
        };

Console.WriteLine("Original Array:");
PrintArray(array);

int[] minElementPosition = FindMinElementPosition(array);
int[,] newArray = RemoveRowAndColumn(array, minElementPosition[0], minElementPosition[1]);

Console.WriteLine("\nArray after removing row and column with the smallest element:");
PrintArray(newArray);

static int[] FindMinElementPosition(int[,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);

    int minValue = int.MaxValue;
    int minRow = -1;
    int minCol = -1;

    for (int row = 0; row < rows; row++)
        for (int col = 0; col < cols; col++)
        {
            if (array[row, col] < minValue)
            {
                minValue = array[row, col];
                minRow = row;
                minCol = col;
            }
        }

    return new int[] { minRow, minCol };
}

static int[,] RemoveRowAndColumn(int[,] array, int rowToRemove, int colToRemove)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);

    int[,] newArray = new int[rows - 1, cols - 1];

    int newRow = 0;
    for (int row = 0; row < rows; row++)
    {
        if (row == rowToRemove)
            continue;

        int newCol = 0;
        for (int col = 0; col < cols; col++)
        {
            if (col == colToRemove)
                continue;

            newArray[newRow, newCol] = array[row, col];
            newCol++;
        }

        newRow++;
    }

    return newArray;
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