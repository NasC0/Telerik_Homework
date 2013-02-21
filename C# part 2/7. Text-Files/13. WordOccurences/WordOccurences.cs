using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class WordOccurences
{
    static List<string> QuickSort(List<string> str)
    {
        List<string> left = new List<string>();
        List<string> right = new List<string>();
        if (str.Count > 0)
        {
            int pivot = str.Count / 2;
            string pivotStr = str[pivot];
            for (int i = 0; i < str.Count; i++)
            {
                if (i != pivot)
                {
                    if (string.Compare(str[i], str[pivot]) >= 0)
                    {
                        right.Add(str[i]);
                    }
                    else
                    {
                        left.Add(str[i]);
                    }
                }
            }

            left = QuickSort(left);
            right = QuickSort(right);
            str.Clear();
            str.AddRange(left);
            str.Add(pivotStr);
            str.AddRange(right);
        }
        return str;
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

    static List<string> OutputMatches(string path, string wordListPath)
    {
        List<string> wordList = WordList(wordListPath);
        List<string> split = new List<string>();
        int count = 0, word = 0;
        try
        {
            StreamWriter writer = new StreamWriter(@"..\..\temp.txt");
            using (writer)
            {
                StreamReader reader = new StreamReader(path);
                using (reader)
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        line = line.ToLower();
                        split = line.Split(' ').ToList();
                        for (int i = 0; i < split.Count; i++)
                        {
                            for (int j = 0; j < wordList.Count; j++)
                            {
                                if (split[i] == wordList[j])
                                {
                                    count++;
                                    word = j;
                                }
                            }
                        }
                        if (count > 0)
                        {
                            writer.WriteLine(wordList[word]);
                        }
                        count = 0;
                        word = 0;
                        split.Clear();
                        line = reader.ReadLine();
                    }
                }
            }
        }
        catch (FileNotFoundException notFoundEx)
        {
            Console.WriteLine(notFoundEx.Message);
        }
        return wordList;
    }

    static void CountOccurences(string path)
    {
        List<string> count = new List<string>();
        int counter = 1;
        try
        {
            List<string> occurence = new List<string>();
            StreamReader reader = new StreamReader(path);
            using (reader)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    occurence.Add(line);
                    line = reader.ReadLine();
                }
            }
            StreamWriter writer = new StreamWriter(@"..\..\result.txt");
            using (writer)
            {
                for (int i = 0; i < occurence.Count; i++)
                {
                    if (i == occurence.Count - 1)
                    {
                        count.Add(counter + ". " + occurence[i]);
                        counter = 1;
                        continue;
                    }
                    else
                    {
                        if (occurence[i] == occurence[i + 1])
                        {
                            counter++;
                        }
                        else
                        {
                            count.Add(counter + ". " + occurence[i]);
                            counter = 1;
                        }
                    }
                }
                count = QuickSort(count);
                count.Reverse();
                for (int i = 0; i < count.Count; i++)
                {
                    writer.WriteLine(count[i]);
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
        string wordListPath = @"..\..\words.txt";
        List<string> occurence = OutputMatches(path, wordListPath);
        CountOccurences(@"..\..\temp.txt");
    }
}
