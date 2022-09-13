// Task23
Console.WriteLine("Enter the number:");
int number = Convert.ToInt32(Console.ReadLine());
void GetTable(int number)
{
    int count = 1;
    while (count <= number)
    {
        Console.WriteLine($"The cube of the number {count} = {Math.Pow(count, 3)}");
        count++;
    }
}
GetTable(number);