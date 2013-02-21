using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter a number for a: ");
        double numA = Double.Parse(Console.ReadLine());
        Console.Write("Enter a number for b: ");
        double numB = Double.Parse(Console.ReadLine());
        Console.Write("Enter a number for c: ");
        double numC = Double.Parse(Console.ReadLine());
        double discriminant;
        if (numA == 0 || numB ==0 || numC == 0)
        {
            Console.WriteLine("This is not a valid quadratic equasion");
        }
        else
        {
           Console.WriteLine("The eqation looks like this: {0}(x*x) + {1}x + {2} = 0", numA, numB, numC);
           discriminant = (numB * numB) - (4 * numA * numC);
           if (discriminant < 0)
           {
               Console.WriteLine("Discriminant = {0}. The equation has no real roots.", discriminant);
           }
           if (discriminant == 0)
           {
               double root = -numB / (2 * numA);
               Console.WriteLine("Discriminant = {0}. The equation has only one root and it is: {1 : 0.0}",discriminant, Math.Round(root, 1));
           }
           if (discriminant > 0)
           {
               Console.WriteLine("Discriminant = {0}", discriminant);
               double firstRoot = (-numB + Math.Sqrt(discriminant)) / (2 * numA);
               Console.WriteLine("The first root is: {0 : 0.0}", Math.Round(firstRoot, 1));
               double secondRoot = (-numB - Math.Sqrt(discriminant)) / (2 * numA);
               Console.WriteLine("The second root is: {0 : 0.0}", Math.Round(secondRoot, 1));
           }
        }
    }
}
