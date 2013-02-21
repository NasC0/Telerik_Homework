using System;
using System.Numerics;
class Program
{
    static void Main()
    {
        Console.WriteLine("Printing the first 100 numbers of the fibonacci sequence: ");
        BigInteger firstHolder = 0;
        BigInteger secondHolder = 1;
        for (int i = 1; i <= 100; i++)
        {
            BigInteger temp = firstHolder;
            firstHolder = secondHolder;
            secondHolder += temp;
            Console.WriteLine("{0}. {1}", i , firstHolder);
        }
    }
}
