using System;
using System.Collections.Generic;
using GenericList.Common;

class EnsureCapacityTest
{
    static void Main()
    {
        GenericList<int> test = new GenericList<int>(10);
        for (int i = 0; i < test.Length; i++)
        {
            test.Add(i);
        }
        Console.WriteLine(test);
        test.Insert(10, 10);
        Console.WriteLine(test);
        test.Insert(15, 15);
        Console.WriteLine(test);
    }
}
