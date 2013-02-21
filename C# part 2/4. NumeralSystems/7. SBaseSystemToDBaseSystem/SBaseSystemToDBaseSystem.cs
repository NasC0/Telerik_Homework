using System;
using System.Collections.Generic;

class SBaseSystemToDBaseSystem
{
    static int SBasedSystem(string convert, int baseNumber)
    {
        convert = Reverse(convert);
        convert = convert.ToLower();
        string numeralSystem = BaseSystem(baseNumber);
        int result = 0;
        for (int i = 0; i < convert.Length; i++)
        {
            for (int j = 0; j < numeralSystem.Length; j++)
            {
                if (convert[i] == numeralSystem[j])
                {
                    result += j * (int)Math.Pow(baseNumber, i);
                }
            }
        }
        return result;
    }

    static string DBasedSystem(int number, int baseNumber)
    {
        string hex = "";
        while (number > 0)
        {
            int remainder = number % baseNumber;
            number = number / baseNumber;
            if (remainder == 10)
            {
                hex = hex + "A";
            }
            else if (remainder == 11)
            {
                hex = hex + "B";
            }
            else if (remainder == 12)
            {
                hex = hex + "C";
            }
            else if (remainder == 13)
            {
                hex = hex + "D";
            }
            else if (remainder == 14)
            {
                hex = hex + "E";
            }
            else if (remainder == 15)
            {
                hex = hex + "F";
            }
            else
            {
                hex = hex + remainder.ToString();
            }
        }
        hex = Reverse(hex);
        return hex;
    }

    static string BaseSystem(int baseNumber)
    {
        string wholeSystem = "0123456789abcdef";
        string revised = "";
        for (int i = 0; i < baseNumber; i++)
        {
            revised += wholeSystem[i];
        }
        return revised;
    }

    static string Reverse(string text)
    {
        char[] cArray = text.ToCharArray();
        string reverse = String.Empty;
        for (int i = cArray.Length - 1; i > -1; i--)
        {
            reverse += cArray[i];
        }
        return reverse;
    }

    static void Main()
    {
        Console.Write("Enter the number you want converted: ");
        string convert = Console.ReadLine();
        Console.Write("Enter the base of its numeric system: ");
        int firstBase = int.Parse(Console.ReadLine());
        int converted = SBasedSystem(convert, firstBase);
        Console.WriteLine("Your number in decimal system is: {0}", converted);
        Console.Write("Enter the base of the numeric system you want your number converted into: ");
        int secondBase = int.Parse(Console.ReadLine());
        string newConverted = DBasedSystem(converted, secondBase);
        Console.WriteLine("Your number in {0} base system is: {1}", secondBase, newConverted);
    }
}
