using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the interval you want checked: ");
        int firstNum = Int32.Parse(Console.ReadLine());
        int secondNum = Int32.Parse(Console.ReadLine());
        int holder = 0;
        for (int i = firstNum; i <= secondNum; i++)
        {
            if ( i % 5 == 0 && i != 0)
            {
                holder++;
            }
        }
        Console.WriteLine("The amount of numbers divisible by 5 in the interval is: {0}", holder);
    }
}
