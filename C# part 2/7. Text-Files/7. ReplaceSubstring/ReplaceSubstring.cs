using System;
using System.IO;
using System.Collections.Generic;

class ReplaceSubstring
{
    static string SubstringReplace(string original, string word, string replace)
    {
        string result = original.Replace(word, replace);
        return result;
    }

    static void ReplaceSubstringInFile(string path, string word, string replace)
    {
        try
        {
            StreamReader reader = new StreamReader(path);
            using (reader)
            {
                StreamWriter writer = new StreamWriter(@"..\..\result.txt");
                using (writer)
                {
                    string file = reader.ReadLine();
                    while (file != null)
                    {
                        file = SubstringReplace(file, word, replace);
                        writer.WriteLine(file);
                        file = reader.ReadLine();
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
        string path = @"..\..\bla.txt";
        ReplaceSubstringInFile(path, "start", "finish");
    }
}
