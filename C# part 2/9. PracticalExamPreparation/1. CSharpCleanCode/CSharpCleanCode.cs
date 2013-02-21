using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class CSharpCleanCode
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] inputCode = new string[n];
        string pattern = @"(@(?:""[^""]*"")+|""(?:[^""\n\\]+|\\.)*""|'(?:[^'\n\\]+|\\.)*')|//.*|/\*(?s:.*?)\*/";
        for (int i = 0; i < inputCode.Length; i++)
        {
            inputCode[i] = Console.ReadLine();
            inputCode[i] = Regex.Replace(inputCode[i], pattern, "$1");
        }
        for (int i = 0; i < inputCode.Length; i++)
        {
            Console.WriteLine(inputCode[i]);
        }
    }
}
