using System;
using System.Diagnostics;
using System.Numerics;
class Program
{
    static void Main()
    {
        Stopwatch sw = new Stopwatch();
        sw.Start();
        Console.Write("Enter the Catalan Number you want calculated: ");
        BigInteger catalanNumber = BigInteger.Parse(Console.ReadLine());
        if (catalanNumber < 0)
        {
            Console.WriteLine("The number must be positive!");
            return;
        }
        BigInteger catNumberTwo = catalanNumber * 2;
        BigInteger catalanFirstDivisor = 1, catalanSecondDivisor = 1, CatalanFactoriel = 1;
        for (int i = 1; i <= catNumberTwo; i++)
        {
            CatalanFactoriel *= i;
        }
        for (int i = 1; i <= (catalanNumber + 1); i++)
        {
            catalanFirstDivisor *= i;
        }
        for (int i = 1; i <= catalanNumber; i++)
        {
            catalanSecondDivisor *= i;
        }
        catalanNumber = CatalanFactoriel / (catalanFirstDivisor * catalanSecondDivisor);
        Console.WriteLine("The catalan number is: {0}", catalanNumber);
        sw.Stop();
        Console.WriteLine("Elapsed: " + sw.Elapsed);
    }
}
