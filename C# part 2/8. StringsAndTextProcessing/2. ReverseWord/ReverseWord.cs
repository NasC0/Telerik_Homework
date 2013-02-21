using System;
using System.Text;

class ReverseWord
{
    static string WordReverse(string str)
    {
        StringBuilder sb = new StringBuilder(str.Length);
        for (int i = str.Length - 1; i >= 0; i--)
        {
            sb.Append(str[i]);
        }
        return sb.ToString();
    }

    static void Main()
    {
        string str = Console.ReadLine();
        str = WordReverse(str);
        Console.WriteLine(str);
    }
}
