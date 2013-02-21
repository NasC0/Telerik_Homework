using System;
using System.IO;

class OddLines
{
    static void PrintOddLine(string path)
    {
        StreamReader reader = new StreamReader(path);
        using (reader)
        {
            while (reader.ReadLine() != null)
            {
                Console.WriteLine(reader.ReadLine());
            }
        }
    }

    static void Main()
    {
        string path = @"..\..\alabala.txt";
        PrintOddLine(path);
    }
}