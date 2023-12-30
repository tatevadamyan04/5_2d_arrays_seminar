//Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] array = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
            };

Console.WriteLine("Enter the row index: ");
int rowIndex = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the column index: ");
int colIndex = int.Parse(Console.ReadLine());

int result = GetElementValue(array, rowIndex, colIndex);

if (result != int.MinValue)
    Console.WriteLine($"The element at position ({rowIndex}, {colIndex}) is: {result}");
else
    Console.WriteLine($"Element at position ({rowIndex}, {colIndex}) does not exist.");

static int GetElementValue(int[,] array, int row, int col)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);

    if (row >= 0 && row < rows && col >= 0 && col < cols)
        return array[row, col];
    else
        return int.MinValue;
}