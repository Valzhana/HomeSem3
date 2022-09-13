Console.WriteLine("Enter a five-digit number:");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(CheckPolindrome(number));
string CheckPolindrome(int number)
{
    int digitCommon = number / 1000;
    int digitSecond = digitCommon % 10;
    int digitFirst = digitCommon / 10;
    int digitCommon1 = number % 100;
    int digitFour = digitCommon1 / 10;
    int digitFive = digitCommon1 % 10;
    if (digitFirst == digitFive && digitSecond == digitFour)
    {
        return "The number is a palindrome";
    }
    else
    {
        return "The number is not a palindrome";
    }
}

