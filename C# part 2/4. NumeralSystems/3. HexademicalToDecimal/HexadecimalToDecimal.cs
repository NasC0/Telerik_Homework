using System;

class HexadecimalToDecimal
{
    static double HexToDecConvert(string hex)
    {
        hex = Reverse(hex);
        string numbers = "0123456789ABCDEF";
        double number = 0;
        for (int i = 0; i < hex.Length; i++)
        {
            for (int j = 0; j < numbers.Length; j++)
            {
                if (hex[i] == numbers[j])
                {
                    number += j * Math.Pow(16, i);
                }
            }
        }
        return number;
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
        Console.Write("Enter the hexademical number you want converted: ");
        string number = Console.ReadLine();
        double result = HexToDecConvert(number);
        Console.Write("Your number in decimal is: ");
        Console.WriteLine(result);
    }
}
