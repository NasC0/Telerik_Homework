using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

class RemovingWords
{
    static string ToCap(string str)
    {
        if (str.Length == 1) return str.ToUpper();
        string firstStr;
        string secondStr;
        firstStr = str.Substring(0, 1).ToUpper();
        secondStr = str.Substring(1).ToLower();
        return firstStr + secondStr;
    }

    static List<string> WordList(string path)
    {
        List<string> wordList = new List<string>();
        try
        {
            StreamReader reader = new StreamReader(path);
            using (reader)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    wordList.Add(line.ToLower());
                    wordList.Add(ToCap(line));
                    line = reader.ReadLine();
                }
            }
        }
        catch (FileNotFoundException notFoundEx)
        {
            Console.WriteLine(notFoundEx.Message);
        }
        return wordList;
    }

    static void RemoveWords(string path, string wordListPath)
    {
        List<string> wordList = WordList(wordListPath);
        StreamReader reader = new StreamReader(path);
        try
        {
            using (reader)
            {
                StreamWriter writer = new StreamWriter(@"..\..\output.txt");
                using (writer)
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        for (int i = 0; i < wordList.Count; i++)
                        {
                            if (line.Contains((wordList[i]) + " ") == true)
                            {
                                line = line.Remove(line.IndexOf(wordList[i]),
                                    wordList[i].Length + 1);
                            }
                            else
                            {
                                while (line.Contains(wordList[i]) == true)
                                {
                                    line = line.Remove(line.IndexOf(wordList[i]),
                                        wordList[i].Length);
                                }
                            }
                        }
                        writer.WriteLine(line);
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
        RemoveWords(@"..\..\bla.txt", @"..\..\words.txt");
    }
}
