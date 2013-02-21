using System;
using System.IO;
using System.Text.RegularExpressions;

class ExtractXML
{
    static void XMLExtract(string path)
    {
        StreamReader reader = new StreamReader(path);
        using (reader)
        {
            StreamWriter writer = new StreamWriter(@"..\..\output.txt");
            using (writer)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    string extracted;
                    foreach (Match match in Regex.Matches(line, ">[^<]*</"))
                    {
                        extracted = match.Value.ToString();
                        extracted = extracted.Remove(extracted.Length - 2, 2);
                        extracted = extracted.Remove(0, 1);
                        if (extracted != null)
                        {
                            writer.WriteLine(extracted);
                        }
                    }
                    line = reader.ReadLine();

                }
            }
        }
    }

    static void Main()
    {
        string path = @"..\..\input.txt";
        XMLExtract(path);
    }
}