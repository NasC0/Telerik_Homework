using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the first number: ");
        int firstNum = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number: ");
        int secondNum = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Which one is bigger: " + Math.Max(firstNum, secondNum));
    }
}
