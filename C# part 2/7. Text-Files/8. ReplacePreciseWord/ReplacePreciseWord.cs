using System;
using System.IO;
using System.Text.RegularExpressions;

class ReplacePreciseWord
{
    static string SubstringReplace(string original, string word, string replace)
    {
        string result = Regex.Replace(original, word, replace);
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
        string word = "start";
        word = @"\b" + word + @"\b";
        ReplaceSubstringInFile(path, word, "finish");
    }
}
