using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number in the range [0,....,9]");
        int number = Int32.Parse(Console.ReadLine());
        if (number < 0 || number > 9)
        {
            Console.WriteLine("please enter a valid number");
            Main();
        }
        else
        {
            switch (number)
            {
                case 1:
                    {
                        Console.WriteLine("One");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Two");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Three");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Four");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Five");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Six");
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("Seven");
                        break;
                    }
                case 8:
                    {
                        Console.WriteLine("Eight");
                        break;
                    }
                case 9:
                    Console.WriteLine("Nine");
                    break;
                default:
                    Console.WriteLine("Zero");
                    break;
            }
        }
    }
}
