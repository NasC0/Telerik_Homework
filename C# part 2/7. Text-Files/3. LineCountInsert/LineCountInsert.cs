using System;
using System.IO;

class LineCountInsert
{
    static void InsertLineCount(string path)
    {
        try
        {
            StreamReader reader = new StreamReader(path);
            using (reader)
            {
                StreamWriter writer = new StreamWriter(@"..\..\result.txt");
                using (writer)
                {
                    int count = 0;
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        count++;
                        writer.WriteLine("Line " + count + ": " + line);
                        line = reader.ReadLine();
                    }
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
        string path = @"..\..\alabala.txt";
        InsertLineCount(path);
    }
}