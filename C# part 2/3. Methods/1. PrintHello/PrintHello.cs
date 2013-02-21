using System;

class PrintHello
{
    static void PrintHelloMethod()
    {
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        Console.WriteLine("Hello {0}!", name);
    }

    static void Main()
    {
        PrintHelloMethod();
    }
}
