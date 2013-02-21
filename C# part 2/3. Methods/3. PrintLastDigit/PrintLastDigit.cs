using System;

class PrintLastDigit
{
    static string ReturnLastDigit(int number)
    {
        number = number % 10;
        string[] numbers = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
        for (int i = 0; i < numbers.Length; i++)
        {
            if (i == number)
            {
                Console.WriteLine(numbers[i]);
                number = i;
            }
        }
        return numbers[number];
    }

    static void Main()
    {
        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        string processedNumber = ReturnLastDigit(number);
    }
}
