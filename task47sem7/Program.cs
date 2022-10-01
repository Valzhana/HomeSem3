// task47
Console.Write("Enter the number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
double[,] CreateArray()
{
    double[,] array = new double[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next());
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    return array;
}
CreateArray();

