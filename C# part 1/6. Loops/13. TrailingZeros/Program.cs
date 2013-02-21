using System;
using System.Numerics;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your number: ");
        int number = Int32.Parse(Console.ReadLine());
        BigInteger factoriel = 1;
        int count = 0;
        int multiplier = 1;
        for (int i = 1; i <= number; i++)
        {
            factoriel *= i;
        }
        while ((number / multiplier) > 0)
        {
            multiplier *= 5;
            count += number / multiplier;
        }
        Console.WriteLine("The factorial of {0} is {1}", number, factoriel);
        Console.WriteLine("The number of trailing zeros is {0}", count);
    }
}
