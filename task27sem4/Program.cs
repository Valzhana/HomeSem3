// Task27
Console.WriteLine("Enter the number:");
int number = Convert.ToInt32(Console.ReadLine());
void GetDigitSum(int number)
{
    int sum = 0;
    number = number*10;
    while (number > 0)
    {
        number = number / 10;
        int result = number % 10;
        sum = sum + result;
    }
    Console.WriteLine($"The sum of the digits in the number is: {sum}");
}
GetDigitSum(number);

