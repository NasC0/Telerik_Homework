using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the number you want counted up to: ");
        int num = Int32.Parse(Console.ReadLine());
        for (int i = 1; i <= num; i++ )
        {
            Console.Write(i + " ");
        }
    }
}
