using System;
class ModifyingByBits
{
    static void Main()
    {
        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the position of the bit you want modified: ");
        int bitPosition = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the value of the bit you want modified: ");
        int bitValue = int.Parse(Console.ReadLine());
        int mask = 1 << bitPosition;
        int maskAndNumber = mask & number;
        int result = maskAndNumber >> bitPosition;
        if (result == 1)
        {
            if (bitValue == 1)
            {
                number = number | mask;
                Console.WriteLine("The bit you want at position " + bitPosition + " has value of " + result + " and you exchange it with " + bitValue);
                Console.WriteLine("The new number is = " + number);
            }
            else
            {
                number = number & ~mask;
                Console.WriteLine("The bit you want at position " + bitPosition + " has value of " + result + " and you exchange it with " + bitValue);
                Console.WriteLine("The new number is = " + number);
            }
        }
        else
        {
            if (bitValue == 1)
            {
                number = number | mask;
                Console.WriteLine("The bit you want at position " + bitPosition + " has value of " + result + " and you exchange it with " + bitValue);
                Console.WriteLine("The new number is = " + number);
            }
            else
            {
                number = number & ~mask;
                Console.WriteLine("The bit you want at position " + bitPosition + " has value of " + result + " and you exchange it with " + bitValue);
                Console.WriteLine("The new number is = " + number);
            }
        }
    
    }
}