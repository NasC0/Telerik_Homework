using System;
class division
{
    static void Main()
    {
        Console.WriteLine("Enter a number: ");
        int divisible = Int32.Parse(Console.ReadLine());
        if (divisible % 5 == 0 && divisible % 7 == 0)
        {
            Console.WriteLine("The number is divisible by 5 and 7 without a remainder");
        }
        else
        {
            Console.WriteLine("The number is not divisible by 5 and 7");
        }
    }
}
