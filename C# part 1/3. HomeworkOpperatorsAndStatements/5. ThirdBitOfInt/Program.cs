using System;
class ThirdBit
{
    static void Main()
    {
        Console.WriteLine("Enter an integer: ");
        int number = int.Parse(Console.ReadLine());
        int mask = 1 << 3;
        int numberAndMask = number & mask;
        int thirdBit = numberAndMask >> 3;
        bool result = (thirdBit == 1);
        if (result)
        {
            Console.WriteLine("The third bit of your number is 1");
        }
        else
        {
            Console.WriteLine("The third bit of your number is 0");
        }
    }
}
