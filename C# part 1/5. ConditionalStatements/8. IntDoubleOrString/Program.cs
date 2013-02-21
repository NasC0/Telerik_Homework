using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("What data type will you enter? (int = 1, double = 2, string = 3): ");
        int dataType = Int32.Parse(Console.ReadLine());
        switch (dataType)
        {
            case 1:
                Console.WriteLine("Enter your integer: ");
                int typeInt = Int32.Parse(Console.ReadLine());
                typeInt += 1;
                Console.WriteLine("The new integer is: {0}", typeInt);
                break;
            case 2:
                Console.WriteLine("Enter your floatint-point number: ");
                double typeDouble = double.Parse(Console.ReadLine());
                typeDouble += 1.0;
                Console.WriteLine("The new floating-point number is: {0}", typeDouble);
                break;
            case 3:
                Console.WriteLine("Enter your string: ");
                string typeString = Console.ReadLine();
                typeString += "*";
                Console.WriteLine("The new string is: {0}", typeString);
                break;
            default:
                Console.WriteLine("Please input 1 for int, 2 for double and 3 for string.");
                Main();
                break;
        }
    }
}
