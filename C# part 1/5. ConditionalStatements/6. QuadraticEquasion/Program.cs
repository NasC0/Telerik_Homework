using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a, b and c: ");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        if (a == 0 || b == 0 || c == 0)
        {
            Console.WriteLine("This is not a real quadratic equation.");
        }
        else
        {
            Console.WriteLine("The quadratic equation is: {0}(x*x) + {1}x + {2} = 0", a, b, c);
            double discriminant = Math.Sqrt((b * b) - (4 * a * c));
            Console.WriteLine("Discriminant: {0 : 0.00}", discriminant);
            if (discriminant < 0)
            {
                Console.WriteLine("The equation has no real roots");
            }
            else if (discriminant == 0)
            {
                double root = -b / (2 * a);
                Console.WriteLine("The equation has only one real root and it's : {0 : 0.0}", Math.Round(root, 1));
            }
            else
            {
                double firstRoot = (-b + Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine("The first root is: {0 : 0.0}", Math.Round(firstRoot, 1));
                double secondRoot = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine("The second root is: {0 : 0.0}", Math.Round(secondRoot, 1));
            }
        }
    }
}
