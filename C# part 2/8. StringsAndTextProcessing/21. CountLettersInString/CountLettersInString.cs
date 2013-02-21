using System;

class CountLettersInString
{
    static void Main()
    {
        char[] chars = new char[65536];
        for (int i = 0; i < chars.Length; i++)
        {
            chars[i] = '0';
        }
        int count = 1;
        string letters = "aabbcceeddffgghhijjkklmmnnopqqrsstttuuuuvwwxxxxxxyyyyyzz";
        for (int i = 0; i < letters.Length; i++)
        {
                count = (int)chars[(int)letters[i]];
                count++;
                chars[(int)letters[i]] = (char)count;
        }
        for (int i = 0; i < chars.Length; i++)
        {
            if (chars[i] != '0' && Char.IsLetter((char)i))
            {
                if (chars[i] == '1')
                {
                    Console.WriteLine("{0} - {1} time", (char)i, chars[i]);
                }
                else
                {
                    Console.WriteLine("{0} - {1} times", (char)i, chars[i]);
                }
            }
        }
    }
}