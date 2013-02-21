using System;
class pointWithinCircle
{
    static void Main()
    {
        Console.WriteLine("Enter coordinates for x: ");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter coordinates for y: ");
        double y = double.Parse(Console.ReadLine());
        if (((x-0)*(x-0)) + ((y-0)*(y-0)) <= 5*5)
        {
            Console.WriteLine("The point (" + x + ", " + y + ") is within the circle K");
        }
        else
        {
            Console.WriteLine("The point is not within the circle");
        }
    }
}