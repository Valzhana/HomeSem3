// Task25
Console.WriteLine("Enter number A:");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number B:");
int numberB = Convert.ToInt32(Console.ReadLine());
void ExponentiateNumber(int numberA, int numberB)
{
    int count = 0;
    int result = 1;
    while (count < numberB)
    {
        result = result*numberA;
        count++;
    }
    Console.WriteLine($"NumberA to the power of numberB is: {result}");
}
ExponentiateNumber(numberA, numberB);

