using System;
class rectangleArea
{
    static void Main()
    {
        Console.WriteLine("Enter the width and height of the rectangle: ");
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        Console.WriteLine("The area of the rectangle is: " + (width * height));
    }
}
