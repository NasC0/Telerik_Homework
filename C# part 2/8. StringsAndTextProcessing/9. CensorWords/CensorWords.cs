using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

class CensorWords
{
    static string[] CensoreWords(string[] words)
    {
        StringBuilder sb = new StringBuilder();
        string[] replaced = new string[words.Length];
        for (int i = 0; i < words.Length; i++)
        {
            for (int j = 0; j < words[i].Length; j++)
            {
                sb.Append('*');
            }
            replaced[i] = sb.ToString();
            sb.Clear();
        }
        return replaced;
    }

    static void Main()
    {
        string forbidden = "Framework";
        string original = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
        string[] split = forbidden.Split(' ');
        string[] censored = CensoreWords(split);
        for (int i = 0; i < split.Length; i++)
        {
            split[i] = split[i].Trim();
            if (Regex.Matches(split[i], @"\b" + split[i] + @"\b", RegexOptions.IgnoreCase).Count > 0)
            {
                original = original.Replace(split[i], censored[i]);
            }
        }
        Console.WriteLine(original);
    }
}
