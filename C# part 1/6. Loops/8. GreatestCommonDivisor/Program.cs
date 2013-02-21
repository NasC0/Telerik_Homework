using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the two numbers you want to find the greatest common divisor to: ");
        int firstNumber = Int32.Parse(Console.ReadLine());
        int secondNumber = Int32.Parse(Console.ReadLine());
        if (secondNumber > firstNumber)
        {
            int temp = secondNumber;
            secondNumber = firstNumber;
            firstNumber = temp;
        }
        if (firstNumber % secondNumber == 0)
        {
            Console.WriteLine("The GCD is: {0}", secondNumber);
        }
        else
        {
            firstNumber -= secondNumber;
            int oldDivisor = firstNumber % secondNumber;
            int newDivisor = secondNumber % oldDivisor;
            while (true)
            {
                int temp = oldDivisor;
                oldDivisor = newDivisor;
                newDivisor = temp;
                newDivisor = newDivisor % oldDivisor;
                if (oldDivisor == 0)
                {
                    Console.WriteLine("The GCD is: " + newDivisor);
                    break;
                }
                else if (newDivisor == 0)
                {
                    Console.WriteLine("The GCD is: " + oldDivisor);
                    break;
                }
            }
        }
    }
}
