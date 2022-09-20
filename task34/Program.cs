// task34
Console.WriteLine("Enter the size of the array:");
int size = Convert.ToInt32(Console.ReadLine());
int[]CreateArray()
{
    Random rnd = new Random();
    int[] array = new int[size];
    for(int index = 0; index < array.Length; index++)
    {
        array[index] = rnd.Next(100,1000);
    }
    return array;
}
void PrintArray(int[]array)
{
    for (int index = 0; index < array.Length; index++)
    {
        Console.Write($"{array[index]}, ");
    }
}
int[]arr = CreateArray();
PrintArray(arr);
int CountEvenNumbers(int[] arr)
{
    int count = 0;
    for (int index = 0; index < arr.Length; index++)
    {
        if (arr[index] % 2 == 0)
        {
            count++;
        }
    }
    Console.WriteLine($"The number of even numbers is: {count}");
    return count; 
}
CountEvenNumbers(arr);


