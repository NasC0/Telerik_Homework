﻿using System;
using System.Text;
using System.IO;

class Dictionary
{
    static void Translate(string input)
    {
        StreamReader reader = new StreamReader(@"..\..\Dictionary.txt");
        try
        {
            using (reader)
            {
                input = input.Trim();
                input = input.ToLower();
                string line = reader.ReadLine();
                while (line != null)
                {
                    line = line.ToLower();
                    if (input == line.Substring(0, input.Length))
                    {
                        Console.WriteLine(line);
                        break;
                    }
                    else
                    {
                        line = reader.ReadLine();
                    }
                }
            }
        }
        catch(IOException)
        {
            Console.WriteLine("Something went wrong while reading the file");
        }
    }

    static void Main()
    {
        Console.WriteLine("Enter the word you want translated: ");
        string word = Console.ReadLine();
        Translate(word);
    }
}
