using System;
class ReadingFromConsole
{
    static void Main()
    {
        Console.WriteLine("Enter your age (numbers only): ");
        int Input = Convert.ToInt32(Console.ReadLine());
        Input = Input + 10;
        Console.WriteLine("After 10 years you will be: " + Input +  " years old");
    }
}
