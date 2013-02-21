using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("How big is your array?");
        int size = int.Parse(Console.ReadLine());
        int[] myArray = new int[size];
        Console.WriteLine("Enter your numbers: ");
        for (int i = 0; i < size; i++)
        {
            myArray[i] = int.Parse(Console.ReadLine());
        }
        int[] reverse = new int[myArray.Length];
        for (int i = 0; i < myArray.Length; i++)
        {
            reverse[i] = myArray[myArray.Length - i - 1];
        }
        Console.WriteLine("Your array in reverse order: ");
        for (int i = 0; i < reverse.Length; i++)
        {
            Console.WriteLine(reverse[i]);
        }
    }
}
