// task68
Console.WriteLine("Enter the first non-negative number:");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second non-negative number:");
int numN = Convert.ToInt32(Console.ReadLine());
int CalcAckermannFunction(int numM, int numN)
{
    if (numM == 0)
    {
        return numN + 1;
    }
    else if (numN == 0 && numM > 0)
    {
        return CalcAckermannFunction(numM - 1, 1);
    }
    else
    {
        return CalcAckermannFunction(numM - 1, CalcAckermannFunction(numM, numN - 1));
    }
}
Console.WriteLine($"Calculation result is: {CalcAckermannFunction(numM, numN)}");
