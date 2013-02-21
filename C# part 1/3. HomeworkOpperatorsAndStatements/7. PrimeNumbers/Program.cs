using System;
class primeNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter the number (must be less than 100): ");
        int primeNumber = Int32.Parse(Console.ReadLine());
        int counter = 0;
        if (primeNumber > 100)
        {
            Console.WriteLine("The number must be less than 100");
        }
        else
        {
            for (int i = 1; i <= primeNumber; i++)
            {
                if (primeNumber % i == 0)
                {
                    ++counter;
                }
            }
            if (counter <= 2)
            {
                Console.WriteLine("The number is prime");
            }
            else if (counter > 2)
            {
                Console.WriteLine("The number is not prime");
            }
        }
    }
}
