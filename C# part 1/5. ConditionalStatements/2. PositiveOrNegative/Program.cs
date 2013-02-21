using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter three numbers: ");
        int firstNumber = Int32.Parse(Console.ReadLine());
        int secondNumber = Int32.Parse(Console.ReadLine());
        int thirdNumber = Int32.Parse(Console.ReadLine());
        if (firstNumber > 0 && secondNumber > 0 && thirdNumber > 0)
        {
            Console.WriteLine("The result is positive.");
        }
        else if (firstNumber < 0 && secondNumber < 0 && thirdNumber < 0)
        {
            Console.WriteLine("The result is negative.");
        }
        else if ((firstNumber < 0 && secondNumber < 0) || (secondNumber < 0 && thirdNumber < 0) || (firstNumber < 0 && thirdNumber < 0))
        {
            Console.WriteLine("The result is positive.");
        }
        else if (firstNumber < 0 || secondNumber < 0 || thirdNumber < 0)
        {
            Console.WriteLine("The result is negative.");
        }
        else if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0)
        {
            Console.WriteLine("The result is 0.");
        }
    }
}
