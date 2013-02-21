using System;

class TriangeSurface
{
    static double TriangleArea(double side, double sideHeight)
    {
        double result = (side * sideHeight) / 2;
        return result;
    }

    static double TriangleArea(double sideA, double sideB, double sideC)
    {
        double p = (sideA + sideB + sideC) / 2;
        double area = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
        return area;
    }

    static double TriangleAreaWithAngle(double sideOne, double sideTwo, double angle)
    {
        double result = (sideOne * sideTwo * Math.Sin(angle)) / 2;
        return result;
    }

    static void Main()
    {
        double firstArea = TriangleArea(3, 3.5);
        Console.WriteLine("{0:0.0}", firstArea);
        double secondArea = TriangleArea(3, 4, 3);
        Console.WriteLine("{0:0.0}", secondArea);
        double thirdArea = TriangleAreaWithAngle(3, 4, 65);
        Console.WriteLine("{0:0.0}", thirdArea);
    }
}
