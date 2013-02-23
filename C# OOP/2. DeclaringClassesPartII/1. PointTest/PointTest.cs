using System;
using Points;

class PointTest
{
    static void Main()
    {
        Point newPoint = new Point();
        newPoint.XCoord = 2;
        newPoint.YCoord = 3;
        newPoint.ZCoord = 4;
        Console.WriteLine(newPoint);
    }
}
