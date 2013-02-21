using System;
using System.Collections.Generic;
using System.IO;

class OmitOddLines
{
    static void OutputEvenLines(string path)
    {
        try
        {
            StreamWriter writer = new StreamWriter(@"..\..\output.txt");
            using (writer)
            {
                StreamReader reader = new StreamReader(path);
                List<string> content = new List<string>();
                using (reader)
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        content.Add(line);
                        line = reader.ReadLine();
                    }
                }
                for (int i = 0; i < content.Count; i += 2)
                {
                    writer.WriteLine(content[i]);
                }
            }
        }
        catch (FileNotFoundException notFoundEx)
        {
            Console.WriteLine(notFoundEx.Message);
        }
    }

    static void Main()
    {
        string path = @"..\..\bla.txt";
        OutputEvenLines(path);
    }
}