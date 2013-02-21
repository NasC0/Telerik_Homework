using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number (must be under 20): ");
        int number = Int32.Parse(Console.ReadLine());
        int counter = 0;
        int numberHolder = number;
        for (int i = 1; i <= number; i++)
        {
            while (counter < i)
            {
                Console.Write(counter + 1 + " ");
                counter++;
            }
        }
    }
}
