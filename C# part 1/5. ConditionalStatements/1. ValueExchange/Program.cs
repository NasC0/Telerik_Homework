using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the first number: ");
        int firstNumber = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number: ");
        int secondNumber = Int32.Parse(Console.ReadLine());
        if (firstNumber >= secondNumber)
        {
            int temp = secondNumber;
            secondNumber = firstNumber;
            firstNumber = temp;
            Console.WriteLine("Exchanged first number and second number");
        }
    }
}
