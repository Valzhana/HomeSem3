// task43
Console.WriteLine("Enter b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
void FindIntersectionPoint(double b1, double k1, double b2, double k2)
{
    double x;
    double y;
    if (k1 == k2 && b1 == b2)
    {
        Console.WriteLine("The lines coincide");
    }
    else if (k1 == k2)
    {
        Console.WriteLine("The lines are parallel");
    }
    else
    {
        x = (b2 - b1) / (k1 - k2);
        y = k2 * x + b2;
        Console.WriteLine($"The intersection point is:({x};{y})");
    }
}
FindIntersectionPoint(b1, k1, b2, k2);

