using System;

class ReversedDigits
{
    static void Reverse(int number)
    {
        string numberString = number.ToString();
        Console.WriteLine("Your reversed number is: ");
        for (int i = numberString.Length - 1; i >= 0; i--)
        {
            Console.Write(numberString[i]);
        }
        Console.WriteLine();
    }

    static void Main()
    {
        Console.Write("Enter the number you want reversed: ");
        int number = int.Parse(Console.ReadLine());
        Reverse(number);
    }
}
