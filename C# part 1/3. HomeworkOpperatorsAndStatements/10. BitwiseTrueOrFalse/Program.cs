using System;
class BitwiseTrueOrFalse
{
    static void Main()
    {
        Console.WriteLine("Enter an integer: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the position of the bit you want tested: ");
        int bitPosition = int.Parse(Console.ReadLine());
        int mask = 1 << bitPosition;
        int numberAndMask = number & mask;
        int thirdBit = numberAndMask >> bitPosition;
        bool result = (thirdBit == 1);
        if (result == true)
        {
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine(result);
        }
    }
}