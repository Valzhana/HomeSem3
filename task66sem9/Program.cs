// task66
Console.WriteLine("Enter the first number:");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number:");
int secondNumber = Convert.ToInt32(Console.ReadLine());
int FindSumOfElements(int firstNumber, int secondNumber)
{
    if (firstNumber > secondNumber)
    {
        if (firstNumber == secondNumber)
        {
            return firstNumber;
        }
        return firstNumber + FindSumOfElements(firstNumber - 1, secondNumber); 
    }
    else
    {
        if (firstNumber == secondNumber)
        {
            return firstNumber;
        }
        return firstNumber + FindSumOfElements(firstNumber + 1, secondNumber);
    }
}
Console.WriteLine($"The sum of the elements is: {(FindSumOfElements(firstNumber, secondNumber))}");

