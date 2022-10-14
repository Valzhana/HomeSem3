// task56
Console.Write("Enter the number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] CreateArray()
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    return array;
}
int[,] arr = CreateArray();
Console.WriteLine($"The row with the minimum sum of elements: {GetRowWithMinSum(arr)}");
int GetRowWithMinSum(int[,] arr)
{
    int row = 0;
    int minsum = 0;
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        minsum = minsum + arr[0, i];
    }

    for (int i = 1; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum = sum + arr[i, j];
        }
        if (minsum > sum)
        {
            minsum = sum;
            row = i;
        }
    }
    return row;
}
GetRowWithMinSum(arr);

