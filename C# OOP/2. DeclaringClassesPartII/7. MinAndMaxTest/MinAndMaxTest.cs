using System;
using System.Collections.Generic;
using GenericList.Common;

class MinAndMaxTest
{
    static void Main()
    {
        GenericList<string> stringTest = new GenericList<string>(10);
        for (int i = 0; i < stringTest.Length; i++)
        {
            stringTest.Add(i.ToString());
        }
        stringTest.Add("Teehee");
        stringTest.Add("Huehue");
        Console.WriteLine(stringTest.Max());
        Console.WriteLine(stringTest.Min());
        GenericList<int> intTest = new GenericList<int>(10);
        for (int i = 0; i < intTest.Length; i++)
        {
            intTest.Add(i);
        }
        Console.WriteLine(intTest.Min());
        Console.WriteLine(intTest.Max());
    }
}
