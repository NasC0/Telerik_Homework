using System;
using System.Collections.Generic;

class DecimalToBinary
{
    static List<byte> DecimalConvert(int number)
    {
        List<byte> binary = new List<byte>();
        while (number > 0)
        {
            binary.Add((byte)(number % 2));
            number /= 2;
        }
        binary.Reverse();
        return binary;
    }

    static void Main()
    {
        Console.Write("What is your number? ");
        int number = int.Parse(Console.ReadLine());
        List<byte> binary = DecimalConvert(number);
        Console.Write("Your number in binary: ");
        int count = 4;
        for (int i = 0; i < binary.Count; i++)
        {
            Console.Write(binary[i]);
        }
        Console.WriteLine();
    }
}
