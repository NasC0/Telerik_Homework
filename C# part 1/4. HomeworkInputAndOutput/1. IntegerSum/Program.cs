using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the numbers you want summed: ");
        int firstNum = Int32.Parse(Console.ReadLine());
        int secondNum = Int32.Parse(Console.ReadLine());
        int thirdNum = Int32.Parse(Console.ReadLine());
        int result = firstNum + secondNum + thirdNum;
        Console.WriteLine("The result is: " + result);
    }
}
