using System;
using System.Numerics;

class MethodFactorial
{
    static void Factorial()
    {
        BigInteger count = 1;
        for (int i = 1; i <= 100; i++)
        {
            Console.Write("The factorial of {0} is: ", i);
            for (int j = 1; j <= i; j++)
            {
                count *= j;
            }
            Console.Write(count);
            count = 1;
            Console.WriteLine();
        }
    }

    static void Main()
    {
        Factorial();
    }
}
