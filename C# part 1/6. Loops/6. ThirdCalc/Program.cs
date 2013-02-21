using System;
using System.Numerics;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter N and X: ");
        int n = Int32.Parse(Console.ReadLine());
        int x = Int32.Parse(Console.ReadLine());
        BigInteger xSquared = x;
        BigInteger sum = 1;
        for (int i = 1; i <= n; i++)
        {
            BigInteger kFactoriel = 1;
            for (int k = 1; k <= i; k++)
            {
                kFactoriel *= k;
            }
            sum += kFactoriel / xSquared;
            xSquared *= x;
        }
        Console.WriteLine("The final sum is: " + sum);
    }
}
