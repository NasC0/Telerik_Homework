using System;
using System.Collections.Generic;

class StringToSumOfInts
{
    static void Main()
    {
        string number = Console.ReadLine();
        int sum = SplitString(number);
        Console.WriteLine(sum);
    }

    static int SplitString(string number)
    {
        int sum = 0;
        string[] splitNumbers = number.Split(' ');
        for (int i = 0; i < splitNumbers.Length; i++)
        {
            sum += int.Parse(splitNumbers[i]);
        }
        return sum;
    }
}
