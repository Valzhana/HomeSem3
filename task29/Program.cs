// Task29
int[] CreateArray()
{
    Random rnd = new Random();
    int[] array = new int[8];
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
int[] arr = CreateArray();
PrintArray(arr);