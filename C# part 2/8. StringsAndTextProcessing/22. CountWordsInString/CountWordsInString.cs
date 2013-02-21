using System;
using System.Collections.Generic;
using System.Text;

class CountWordsInString
{
    static void Main()
    {
        Dictionary<string, int> wordCount = new Dictionary<string, int>();
        string words = "Hello there are there there there hello many words words many in this string this";
        char[] splitRegulations = { ' ', '.', '!', '?', ',', '-', ':', ';' };
        string[] wordSplit = words.Split(splitRegulations, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < wordSplit.Length; i++)
        {
            if (wordCount.ContainsKey(wordSplit[i]))
            {
                wordCount[wordSplit[i]]++;
            }
            else
            {
                wordCount.Add(wordSplit[i], 1);
            }
        }
        foreach (KeyValuePair<string, int> pair in wordCount)
        {
            if (pair.Value == 1)
            {
                Console.WriteLine("{0} - {1} time", pair.Key, pair.Value);
            }
            else
            {
                Console.WriteLine("{0} - {1} times", pair.Key, pair.Value);
            }
        }
    }
}
