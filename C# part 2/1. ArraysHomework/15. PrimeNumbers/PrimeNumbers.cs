using System;
using System.Collections.Generic;
using System.Threading;

class PrimeNumbers
{
    static void Main()
    {
        long size = 10000000;
        bool[] numbers = new bool[10000000];
        for (long i = 2; i < Math.Sqrt(size); i++)
        {
            if (numbers[i] == false)
            {
                for (long j = i * i; j < 10000000; j = j + i)
                {
                    numbers[j] = true;
                }
            }
        }

        List<bool> count = new List<bool>();
        for (int i = 2; i < size; i++)
        {
            if (numbers[i] == false)
            {
                count.Add(numbers[i]);
            }
        }
        Console.WriteLine("The total number of prime numbers in the interval (2... 10 000 000) is: {0}", count.Count);
        Console.WriteLine("You've got 10 seconds until Wall of Text hits you. You've been warned.");
        Thread.Sleep(10000);
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == false)
            {
                Console.Write("{0} ", i);    // !false to help clarify that these are the prime numbers
            }
        }
    }
}
