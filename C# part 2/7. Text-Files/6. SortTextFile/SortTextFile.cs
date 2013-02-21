using System;
using System.IO;
using System.Collections.Generic;

class SortTextFile
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

    static void SortFile(string path)
    {
        try
        {
            StreamWriter writer = new StreamWriter(@"..\..\result.txt");
            using (writer)
            {
                StreamReader reader = new StreamReader(path);
                List<string> readList = new List<string>();
                using (reader)
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        readList.Add(line);
                        line = reader.ReadLine();
                    }
                }
                List<string> sortedList = QuickSort(readList);
                for (int i = 0; i < sortedList.Count; i++)
                {
                    writer.WriteLine(sortedList[i]);
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
        string path = @"..\..\names.txt";
        SortFile(path);
    }
}
