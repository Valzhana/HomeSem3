// task38
Console.WriteLine("Enter the size of the array:");
int size = Convert.ToInt32(Console.ReadLine());
double[]CreateArray()
{   
    Random rnd = new Random();
    double[] array = new double[size];
    for(int index = 0; index < array.Length; index++)
    {
        array[index] = Convert.ToDouble(new Random().Next());
    }
    return array;
}
void PrintArray(double[]array)
{
    for (int index = 0; index < array.Length; index++)
    {
        Console.Write($"{array[index]}, ");
    }
}
double[]arr = CreateArray();
PrintArray(arr);
void FindTheDifference(double[] arr)
{
    double max = arr[0];
    double min = arr[0];
    for (int index = 0; index < arr.Length; index++)
    {
        if (arr[index] > max)
        {
            max = arr[index];
        }
        if (arr[index] < min)
        {
            min = arr[index];
        }
    }
    Console.WriteLine($"The difference between the elements is: {max - min}"); 
}
FindTheDifference(arr);


