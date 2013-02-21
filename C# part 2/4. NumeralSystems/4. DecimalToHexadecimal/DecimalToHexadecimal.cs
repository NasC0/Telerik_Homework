using System;
using System.Collections.Generic;

class DecimalToHexadecimal
{
    static string DecToHex(int number)
    {
        string hex = "";
        while (number > 0)
        {
            int remainder = number % 16;
            number = number / 16;
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
        Console.Write("Enter the number you want converted to hex: ");
        int number = int.Parse(Console.ReadLine());
        string hex = DecToHex(number);
        Console.WriteLine("Your converted number is: {0}", hex);
    }
}
