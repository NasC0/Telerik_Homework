using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("How much numbers will you input: ");
        int n = Int32.Parse(Console.ReadLine());
        int holder;
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            Console.Write("Enter number " + i + ": ");
            holder = Int32.Parse(Console.ReadLine());
            sum += holder;
        }
        Console.WriteLine("The sum of all the inputs is: {0}", sum );
    }
}
