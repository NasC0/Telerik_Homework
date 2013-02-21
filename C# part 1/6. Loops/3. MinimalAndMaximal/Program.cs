using System;
class Program
{
    static void Main()
    {
        Console.Write("How many numbers will you enter? ");
        int number = Int32.Parse(Console.ReadLine());
        int numbers;
        int smallest = 0;
        int biggest = 0;
        for (int i = 0; i < number; i++)
        {
            numbers = Int32.Parse(Console.ReadLine());
            if (i == 0)
            {
                smallest = numbers;
                biggest = numbers;
            }
            if (numbers < smallest)
            {
                smallest = numbers;
            }
            if (biggest < numbers)
            {
                biggest = numbers;
            }
        }
        Console.WriteLine("The smallest number is: {0}", smallest);
        Console.WriteLine("The biggest number is: {0}", biggest);
    }
}