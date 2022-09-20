// task36
Console.WriteLine("Enter the size of the array:");
int size = Convert.ToInt32(Console.ReadLine());
int[]CreateArray()
{
    Random rnd = new Random();
    int[] array = new int[size];
    for(int index = 0; index < array.Length; index++)
    {
        array[index] = rnd.Next();
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
int GetSumOfElements(int[] arr)
{
    int sum = 0;
    for (int index = 1; index < arr.Length; index+=2)
    {
        sum += arr[index];
    }
    Console.WriteLine($"The sum of elements is:{sum}");
    return sum; 
}
GetSumOfElements(arr);



