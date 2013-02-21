using System;
class BitExtraction
{
    static void Main()
    {
        Console.WriteLine("Enter the number you want extraction from: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the number of the bit you want extracted: ");
        int bitNumber = int.Parse(Console.ReadLine());
        int mask = 1 << bitNumber;
        int maskAndNumber = mask & number;
        int bitValue = maskAndNumber >> bitNumber;
        Console.WriteLine("The value of the " + bitNumber + "th bit is: " + bitValue);
    }
}