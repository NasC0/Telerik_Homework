using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the number you want counted up to: ");
        int number = Int32.Parse(Console.ReadLine());
        for (int i = 1; i <= number; i++)
        {
            if (i % 3 == 0 && i % 7 == 0)
            {
                Console.WriteLine("{0}", i);
            }
        }
    }
}
