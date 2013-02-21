using System;
class Program
{
    static void Main()
    {
        Console.Write("What number to count up to?: ");
        int number = Int32.Parse(Console.ReadLine());
        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine("{0}", i);
        }
    }
}
