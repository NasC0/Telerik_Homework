using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class RemoveTest
{
    static void RemoveWord(string path)
    {
        try
        {
            StreamReader reader = new StreamReader(path);
            using (reader)
            {
                StreamWriter writer = new StreamWriter(@"..\..\output.txt");
                using (writer)
                {
                    string line = reader.ReadLine();
                    List<string> holder = new List<string>();
                    while (line != null)
                    {
                        holder = line.Split(' ').ToList();
                        if (holder.Count <= 1)
                        {
                            if (holder[0].Substring(0, 4) == "test")
                            {
                                holder.Clear();
                                line = reader.ReadLine();
                                continue;
                            }
                            else
                            {
                                writer.WriteLine(holder[0]);
                                holder.Clear();
                                line = reader.ReadLine();
                            }
                        }
                        else
                        {
                            for (int i = 0; i < holder.Count; i++)
                            {
                                if (holder[i].Length >= 4 && holder[i].Substring(0, 4) == "test")
                                {
                                    line = line.Remove(line.IndexOf(holder[i]), holder[i].Length);
                                }
                            }
                            writer.WriteLine(line);
                            holder.Clear();
                            line = reader.ReadLine();
                        }
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
        string path = @"..\..\input.txt";
        RemoveWord(path);
    }
}