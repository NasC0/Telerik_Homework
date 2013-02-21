using System;
class RandomBitPositions
{
    static void Main()
    {
        Console.WriteLine("Enter the number you want the bits of switched: ");
        uint number = uint.Parse(Console.ReadLine());
        Console.WriteLine("First bit sequence start position: ");
        int firstBitStartPosition = int.Parse(Console.ReadLine());
        Console.WriteLine("Second bit sequence start position: ");
        int secondBitStartPosition = int.Parse(Console.ReadLine());
        Console.WriteLine("Amount of bits to be switched: ");
        int length = int.Parse(Console.ReadLine());
        Console.WriteLine();
        uint firstMask;
        uint secondMask;
        for (int i = firstBitStartPosition; i <= (firstBitStartPosition + (length - 1)); i++)
        {
            firstMask = (uint)1 << i;
            uint firstResult = firstMask & number;
            firstResult >>= i;
            Console.WriteLine("The bit at position " + i + " has value of " + firstResult);
            Console.WriteLine();
            secondMask = (uint)1 << secondBitStartPosition;
            uint secondResult = secondMask & number;
            secondResult >>= secondBitStartPosition;
            Console.WriteLine("The bit at position " + secondBitStartPosition + " has value of " + secondResult);
            Console.WriteLine();
            if (firstResult != secondResult)
            {
                if (firstResult == 1)
                {
                    number = number | secondMask;
                    Console.WriteLine("Exchanged position " + i + " with position " + secondBitStartPosition);
                    Console.WriteLine();
                }
                if (firstResult == 0)
                {
                    number = number & ~secondMask;
                    Console.WriteLine("Exchanged position " + i + " with position " + secondBitStartPosition);
                    Console.WriteLine();
                }
                if (secondResult == 1)
                {
                    number = number | firstMask;
                    Console.WriteLine("Exchanged position " + secondBitStartPosition + " with position " + i);
                    Console.WriteLine();
                }
                if (secondResult == 0)
                {
                    number = number & ~firstMask;
                    Console.WriteLine("Exchanged position " + secondBitStartPosition + " with position " + i);
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Nothing to exchange");
                Console.WriteLine();
            }
            secondBitStartPosition++;
        }
        Console.WriteLine("The new number generated after bit position exchanging is: " + number);
    }
}
