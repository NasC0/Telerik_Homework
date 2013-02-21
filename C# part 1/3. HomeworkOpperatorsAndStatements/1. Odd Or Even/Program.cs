using System;
class oddOrEven
{
    static void Main()
    {
        Console.WriteLine("Enter a number: ");
        int evenOrOdd = Int32.Parse(Console.ReadLine());
        if (evenOrOdd%2 == 0)
        {
            Console.WriteLine("The number is even");
        }
        else
        {
            Console.WriteLine("The number is odd");
        }
    }
}
