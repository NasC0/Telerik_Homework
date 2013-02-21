using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter three numbers: ");
        int firstNumber = Int32.Parse(Console.ReadLine());
        int secondNumber = Int32.Parse(Console.ReadLine());
        int thirdNumber = Int32.Parse(Console.ReadLine());
        if (firstNumber == secondNumber && firstNumber == thirdNumber && secondNumber == thirdNumber)
        {
            Console.WriteLine("The numbers are equal.");
        }
        else
        {
            if (firstNumber >= secondNumber)
            {
                if (thirdNumber >= firstNumber)
                {
                    Console.WriteLine("The third number is the biggest.");
                }
                else
                {
                    Console.WriteLine("The first number is the biggest");
                }
            }
            else
            {
                if (thirdNumber >= secondNumber)
                {
                    Console.WriteLine("The third number is the biggest.");
                }
                else
                {
                    Console.WriteLine("The second number is the biggest");
                }
            }
        }
    }
}
