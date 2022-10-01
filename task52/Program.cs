// task52
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
void FindAverageInColumn(int[,] arr)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {   
        double sum = 0;
        double average = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum += arr[i, j];
            average = sum / rows;
        }
        Console.WriteLine($"The average of {j} column: {average}");
    }
}
FindAverageInColumn(arr);
