﻿int[,] matrix = new int[4, 4];
int temp = 1;
int i = 0;
int j = 0;
while (temp <= matrix.GetLength(0) * matrix.GetLength(1))
{
    matrix[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < matrix.GetLength(1) - 1)
    {
        j++;
    }
    else if (i < j && i + j >= matrix.GetLength(0) - 1)
    {
        i++;
    }
    else if (i >= j && i + j > matrix.GetLength(1) - 1)
    {
        j--;
    }
    else
    {
        i--;
    }
}
PrintArray(matrix);
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] / 10 <= 0)
            {
                Console.Write($" {array[i, j]} ");
            }
            else
            {
                Console.Write($"{array[i, j]} ");
            }
        }
        Console.WriteLine();
    }
}
