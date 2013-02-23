using System;
using Points;
using System.Collections.Generic;

class PathTest
{
    static void Main()
    {
        Path path = new Path();
        path.AddPoint(new Point(1, 2, 3));
        path.AddPoint(Point.CoordStart);
        path.AddPoint(new Point(4, 5, 6));
        path.AddPoint(new Point(7, 8, 9));
        Console.WriteLine(path.ToString());
        string filePath = @"..\..\save.txt";
        PathStorage.SavePath(filePath, path);
        Path pathLoad = PathStorage.LoadPath(filePath);               
        Console.WriteLine(pathLoad.ToString());
    }
}
