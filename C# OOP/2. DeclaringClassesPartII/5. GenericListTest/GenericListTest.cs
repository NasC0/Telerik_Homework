using System;
using System.Collections.Generic;
using GenericList.Common;

class GenericListTest
{
    static void Main()
    {
        GenericList<int> test = new GenericList<int>(10);
        for (int i = 0; i < test.Length; i++)
        {
            test.Add(i);
        }
        Console.WriteLine(test.ToString());
        test.Remove(9);
        Console.WriteLine(test.ToString());
        test.Insert(9, 9);
        Console.WriteLine(test);
        GenericList<int> newTest = new GenericList<int>(10);
        for (int i = 0; i < newTest.Length - 1; i++)
        {
            newTest.Add(i);
        }
        Console.WriteLine(newTest);
        newTest.Insert(10, 9);
        Console.WriteLine(newTest);
        newTest.Clear();
        Console.WriteLine(newTest);
        Console.WriteLine(test[3]);
        GenericList<string> stringTest = new GenericList<string>(10);
        for (int i = 0; i < stringTest.Length - 2; i++)
        {
            stringTest.Add(i.ToString());
        }
        Console.WriteLine(stringTest);
        stringTest.Add("huehuehueheuhe");
        Console.WriteLine(stringTest);
        stringTest.Insert("Teehee", 9);
        Console.WriteLine(stringTest);
    }
}
