using System;
using System.Collections.Generic;

class ReverseOrderOfWordsInString
{
    static string ReverseWordOrder(string str)
    {
        char sign = str[str.Length - 1];
        char[] separators = { '!', '.', '?', ',', ';' };
        str = str.Remove(str.Length - 1);
        string[] words = str.Split(' ');
        char[] separatorPlaces = new char[words.Length];
        for (int i = 0; i < separatorPlaces.Length; i++)
        {
            separatorPlaces[i] = '0';
        }
        for (int i = 0; i < words.Length; i++)
        {
            for (int j = 0; j < separators.Length; j++)
            {
                if (words[i][words[i].Length - 1] == separators[j])
                {
                    int length = words[i].Length - 1;
                    separatorPlaces[i] = words[i][length];
                    words[i] = words[i].Remove(words[i].Length - 1);
                }
            }
        }
        Array.Reverse(words);
        for (int i = 0; i < words.Length; i++)
        {
            if (separatorPlaces[i] != '0')
            {
                words[i] = words[i].Insert(words[i].Length, separatorPlaces[i].ToString());
            }
        }
        string result = string.Join(" ", words);
        result = result + sign;
        return result;
    }

    static void Main()
    {
        string str = "C# is not C++, not PHP and not Delphi!";
        Console.WriteLine(str);
        str = ReverseWordOrder(str);
        Console.WriteLine(str);
    }
}
