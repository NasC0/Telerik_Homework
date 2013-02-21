using System;
class area
{
    static void Main()
    {
        Console.WriteLine("input the dimensions of the trapezium: ");
        double sideA = double.Parse(Console.ReadLine());
        double sideB = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        Console.WriteLine("The area of the trapezium is: " + ((sideA+sideB) / 2 * height));
    }
}
