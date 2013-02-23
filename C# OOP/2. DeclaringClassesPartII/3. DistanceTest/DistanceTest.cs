using System;
using Points;

class DistanceTest
{
    static void Main()
    {
        Point firstPoint = new Point(1, 2, 3);
        Point secondPoint = Point.CoordStart;
        int distance = Distance.Calculate(firstPoint, secondPoint);
        Console.WriteLine(distance);
    }
}
