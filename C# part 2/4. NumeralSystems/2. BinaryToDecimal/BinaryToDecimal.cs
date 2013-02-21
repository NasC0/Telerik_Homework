using System;

class BinaryToDecimal
{
    static double BinaryConverter(byte[] binary)
    {
        double number = 0;
        for (int i = 0; i < binary.Length; i++)
        {
            number += binary[i] * Math.Pow(2, i);
        }
        return number;
    }

    static byte[] ArrayCreator()
    {
        Console.Write("Enter the length of your binary number: ");
        int size = int.Parse(Console.ReadLine());
        if (size < 1)
        {
            Console.WriteLine("The sequence must not be empty");
            return ArrayCreator();
        }
        byte[] array = new byte[size];
        Console.WriteLine("Enter your number (press \"enter\") after every element.");
        Console.Write("Right to left: ");
        for (int i = size - 1; i >= 0; i--)
        {
            array[i] = byte.Parse(Console.ReadLine());
        }
        return array;
    }

    static void Main()
    {
        byte[] array = ArrayCreator();
        double number = BinaryConverter(array);
        Console.WriteLine("The converted number is: " + number);
    }
}
