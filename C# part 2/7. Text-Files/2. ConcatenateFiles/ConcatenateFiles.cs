using System;
using System.IO;

class ConcatenateFiles
{
    static void Concatenate(string firstPath, string secondPath)
    {
        try
        {
            StreamWriter writer = new StreamWriter(@"..\..\result.txt", true);
            using (writer)
            {
                StreamReader reader = new StreamReader(firstPath);
                using (reader)
                {
                    writer.WriteLine(reader.ReadToEnd());
                }
                reader = new StreamReader(secondPath);
                using (reader)
                {
                    writer.WriteLine(reader.ReadToEnd());
                }
            }
        }
        catch (FileNotFoundException notFound)
        {
            Console.WriteLine(notFound.Message);
        }
    }

    static void Main()
    {
        string firstPath = @"..\..\alabala.txt";
        string secondPath = @"..\..\bla.txt";
        Concatenate(firstPath, secondPath);
    }
}