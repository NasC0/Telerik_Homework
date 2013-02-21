using System;
class ExchangingBitPositions
{
    static void Main()
    {
        Console.WriteLine("Enter a number: ");
        uint number = uint.Parse(Console.ReadLine());
        uint mask;
        uint secondaryMask;
        int secondaryBitPosition = 24;
        for (int i = 3; i <= 5; i++)
        {
            mask = (uint)1 << i;
            uint maskAndNumber = mask & number;
            uint result = maskAndNumber >> i;
            Console.WriteLine("The bit at position " + i + " has value of " + result);
            secondaryMask = (uint)1 << secondaryBitPosition;
            uint secondaryResult = maskAndNumber >> secondaryBitPosition;
            Console.WriteLine("The bit at position " + secondaryBitPosition + " has value of " + secondaryResult);
            if (result != secondaryResult)
            {
                if (result == 1)
                {
                    number = number | secondaryMask;
                    Console.WriteLine("Exchanged position " + i + " with position " + secondaryBitPosition);
                }
                if (result == 0)
                {
                    number = number & ~secondaryMask;
                    Console.WriteLine("Exchanged position " + i + " with position " + secondaryBitPosition);
                }
                if (secondaryResult == 1)
                {
                    number = number | mask;
                    Console.WriteLine("Exchanged position " + secondaryBitPosition + " with position " + i);
                }
                if (secondaryResult == 0)
                {
                    number = number & ~mask;
                    Console.WriteLine("Exchanged position " + secondaryBitPosition + " with position " + i);
                }
            }
            else
            {
                Console.WriteLine("Nothing to exchange");
            }
            secondaryBitPosition++;
        }
        Console.WriteLine("The new number generated after bit position exchanging is: " + number);
    }
}
