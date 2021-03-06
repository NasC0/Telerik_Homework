﻿using System;
using System.Numerics;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your two numbers: ");
        int n = Int32.Parse(Console.ReadLine());
        int k = Int32.Parse(Console.ReadLine());
        if (n > k)
        {
            Console.WriteLine("The first number must be in the interval (0 < n < k)");
            Main();
        }
        else
        {
            BigInteger nFactoriel = 1;
            BigInteger kFactoriel = 1;
            for (int i = 1; i <= n; i++)
            {
                nFactoriel *= i;
            }
            Console.WriteLine("N! is: {0}", nFactoriel);
            for (int i = 1; i <= k; i++)
            {
                kFactoriel *= i;
            }
            Console.WriteLine("K! is: {0}", kFactoriel);
            Console.WriteLine("The result after factoriel operations is: " + ((nFactoriel * kFactoriel) / (k - n)));
        }
    }
}
