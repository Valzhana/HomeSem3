// task50
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
            array[i, j] = new Random().Next(0, 20);
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    return array;
}
Console.Write("Enter the row number: ");
int rowNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the column number: ");
int columnNumber = Convert.ToInt32(Console.ReadLine());
int[,] arr = CreateArray();
void FindElementByPosition(int rowNumber, int columnNumber)
{
    if (rowNumber < arr.GetLength(0) && columnNumber < arr.GetLength(1))
    {
        Console.WriteLine($"The number {arr[rowNumber, columnNumber]} is in this position");
    }
    else
    {
        Console.WriteLine("There is no such element in the array");
    }
}
FindElementByPosition(rowNumber, columnNumber);

