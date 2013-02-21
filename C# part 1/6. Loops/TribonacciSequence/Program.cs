using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        int firstNum = Int32.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int secondNum = Int32.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int thirdNum = Int32.Parse(Console.ReadLine());
        Console.Write("Enter the number you want calculated up to: ");
        int number = Int32.Parse(Console.ReadLine());
        if (number <= 0)
        {
            Console.WriteLine("Please enter a positive number > 0");
            return;
        }
        else if (number == 1)
        {
            Console.WriteLine("The {0}st number of the tribonacci sequence is: {1}", number, firstNum);
        }
        else if (number == 2)
        {
            Console.WriteLine("The {0}nd number of the tribonacci sequence is: {1}", number, secondNum);
        }
        else if (number == 3)
        {
            Console.WriteLine("The {0}rd number of the tribonacci sequence is: {1}", number, thirdNum);
        }
        else
        {
            int sum = thirdNum;
            for (int i = 1; i < number - 2; i++)
            {
                sum = firstNum + secondNum + thirdNum;
                firstNum = secondNum;
                secondNum = thirdNum;
                thirdNum = sum;
            }
            Console.WriteLine("The {0}th number of the tribonacci sequnce is: {1}", number, sum);
        }
    }
}
