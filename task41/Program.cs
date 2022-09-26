// task41
Console.Write("Enter the number of your numbers: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] EnterFromTheKeyboard()
{
    int[] array = new int[size];
    for (int index = 0; index < array.Length; index++)
    {
        Console.Write($"Enter the number {index}:\t ");
        array[index] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
int[] arr = EnterFromTheKeyboard();
int CountPositiveNumbers(int[] arr)
{
    int count = 0;
    for (int index = 0; index < arr.Length; index++)
    {
        if (arr[index] > 0)
        {
            count++;
        }
    }
    Console.WriteLine($"The number of positive numbers is: {count}");
    return count;
}
CountPositiveNumbers(arr);


