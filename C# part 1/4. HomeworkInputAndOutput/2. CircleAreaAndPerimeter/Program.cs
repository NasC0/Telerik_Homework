using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter the radius of the circle: ");
        double radius = Double.Parse(Console.ReadLine());
        double area = Math.PI * (radius * radius);
        Console.WriteLine("The area of the circle is: {0 : 0.00}", area);
        double perimeter = Math.PI * (radius * 2);
        Console.WriteLine("The perimeter of the circle is: {0 : 0.00}", perimeter);
    }
}
