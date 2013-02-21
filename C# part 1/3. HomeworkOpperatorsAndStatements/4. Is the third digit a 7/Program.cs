using System;
class digitCounter
{
    static void Main()
    {
        Console.WriteLine("Enter a Number: ");
        int number = Int32.Parse(Console.ReadLine());
        int NumberDivision = number / 100;
        int divisionRemainder = NumberDivision % 10;
        if (divisionRemainder == 7)
        {
            Console.WriteLine("The third digit of the number is 7.");
        }
        else
        {
            Console.WriteLine("The third digit of the number is not 7");
        }
    }
} 
