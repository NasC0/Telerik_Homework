using System;
class circleAndRectangle
{
    static void Main()
    {
        Console.WriteLine("Enter x coordinates for circle K: ");
        double circleXPoint = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter y coordinates for circle K: ");
        double circleYPoint = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the radius for circle K: ");
        double circleRadius = double.Parse(Console.ReadLine());
        Console.WriteLine("To check if a point is within the circle K((" + circleXPoint +", " + circleYPoint + "), " + circleRadius + ") enter the x coordinates: ");
        double pointX = double.Parse(Console.ReadLine());
        Console.WriteLine("Now enter the y coordinates: ");
        double pointY = double.Parse(Console.ReadLine());
        if (((pointX - circleXPoint) * (pointX - circleXPoint)) + ((pointY - circleYPoint) * (pointY - circleYPoint)) <= circleRadius * circleRadius)
        {
            Console.WriteLine("The point (" + pointX + ", " + pointY + ") is within the circle K");
            if ((pointX >= -1 && pointX <= 5) && (pointY >= -1 && pointY <= 1))
            {
                Console.WriteLine("The point is within the rectangle");
            }
            else
            {
                Console.WriteLine("The point is not in the rectangle");
            }
            
        }
        else
        {
            Console.WriteLine("The point (" + pointX + ", " + pointY + ") is not within the circle K:");
            if ((pointX >= -1 && pointX <= 5) && (pointY >= -1 && pointY <= 1))
            {
                Console.WriteLine("The point is within the rectangle");
            }
            else
            {
                Console.WriteLine("The point is not in the rectangle");
            }
        }
    }
}
