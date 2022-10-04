// task64
Console.Write("Enter natural number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(PrintNumber(number, 1));
string PrintNumber(int start, int end)
{
    if (start == end)
    {
        return start.ToString();
    }
    return(start +"," + PrintNumber(start -1, end));
}
