using System;
using System.Numerics;
class Program
{
    static void Main()
    {
        Console.Write("Enter the length of the fibonacci sequence you want calculated: ");
        BigInteger num = BigInteger.Parse(Console.ReadLine());
        BigInteger firstNumber = 0;
        BigInteger secondNumber = 1;
        BigInteger sum = 0;
        if (num == 0)
        {
            sum = 0;
        }
        else if (num == 1)
        {
            sum = 1;
        }
        else
        {
            for (int i = 1; i < num; i++)
            {
                sum = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = sum;
            }
        }
        Console.WriteLine("The sum is: {0}", sum);
    }
}
