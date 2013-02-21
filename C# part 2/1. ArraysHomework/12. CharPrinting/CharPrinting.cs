using System;
using System.Collections.Generic;

class CharPrinting
{
    static void Main()
    {
        string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ ";
        int size = alphabet.Length;
        Console.WriteLine("What word do you want broken down?");
        string wordSearch = Console.ReadLine();
        wordSearch = wordSearch.ToUpper();
        int searchSize = wordSearch.Length;
        List<int> foundWord = new List<int>();
        for (int i = 0; i < searchSize; i++)
        {
            for (int j = 0; j < size; j++)
            {
                if (alphabet[j] == wordSearch[i])
                {
                    foundWord.Add(j);
                }
            }
        }

        for (int i = 0; i < foundWord.Count; i++)
        {
            if (foundWord[i] == 26)
            {
                Console.WriteLine();
            }
            else if(foundWord[i] < 26)
            {
                Console.WriteLine("alphabet[{0:00}] = {1}", foundWord[i], alphabet[foundWord[i]]);
            }
        }
        Console.WriteLine();
    }
}
