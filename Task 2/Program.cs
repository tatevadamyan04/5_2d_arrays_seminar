//Задача 2: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

int[,] array = {
            {1, 2, 3, 4},
            {5, 6, 7, 8},
            {9, 10, 11, 12}
            };

Console.WriteLine("Original Array:");
PrintArray(array);

SwapRows(array, 0, array.GetLength(0) - 1);

Console.WriteLine("\nArray after swapping first and last rows:");
PrintArray(array);

static void SwapRows(int[,] array, int row1, int row2)
{
    int cols = array.GetLength(1);

    for (int col = 0; col < cols; col++)
    {
        int temp = array[row1, col];
        array[row1, col] = array[row2, col];
        array[row2, col] = temp;
    }
}

static void PrintArray(int[,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);

    for (int row = 0; row < rows; row++)
    {
        for (int col = 0; col < cols; col++)
            Console.WriteLine($"{array[row, col]} ");
        Console.WriteLine();
    }
}