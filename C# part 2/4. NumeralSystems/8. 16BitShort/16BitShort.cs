using System;
using System.Collections.Generic;

class _16BitShort
{
    static List<short> CheckNumber(int number)
    {
        List<short> binary = new List<short>();
        if (number > 0)
        {
            while (number > 0)
            {
                binary.Add((short)(number % 2));
                number /= 2;
            }
        }
        else if (number < 0)
        {
            number = Math.Abs(number) - 1;
            while (number > 0)
            {
                binary.Add((short)(number % 2));
                number /= 2;
            }
        }
        return binary;
    }

    static string DecimalConvert(int number)
    {
        List<short> binary = CheckNumber(number);
        string hue = "";
        int size = 16 - binary.Count;
        int count = 4;
        if (number > 0)
        {
            for (int i = 0; i < 16; i++)
            {
                if (i % count == 0 && i != 0)
                {
                    hue += " ";
                    count = count + 4;
                }
                if (i < binary.Count)
                {
                    hue += binary[i].ToString();
                }
                else
                {
                    hue += "0";
                }
            }
        }
        else if (number < 0)
        {
            for (int i = 0; i < 16; i++)
            {
                if (i % count == 0 && i != 0)
                {
                    hue += " ";
                    count = count + 4;
                }
                if (i < binary.Count)
                {
                    if (binary[i] == 1)
                    {
                        hue += "0";
                    }
                    else
                    {
                        hue += "1";
                    }
                }
                else
                {
                    hue += "1";
                }
            }
        }
        hue = Reverse(hue);
        return hue;
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
        Console.WriteLine("{0} - {1}", short.MinValue, short.MaxValue);
        Console.Write("What is your number? ");
        short number = short.Parse(Console.ReadLine());
        string binary = DecimalConvert(number);
        Console.WriteLine("Your number in binary: " + binary);
    }
}
