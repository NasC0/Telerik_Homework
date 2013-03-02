using System;
using System.Collections.Generic;
using GenericList.Common;

class GenericListTest
{
    static void Main()
    {
        GenericList<int> bla = new GenericList<int>(10);
        for (int i = 0; i < 20; i++)
        {
            bla.Add(i);
        }
        Console.WriteLine(bla.ToString());
        bla.Remove(15);
        Console.WriteLine(bla.ToString());
        bla.Insert(15, 15);
        Console.WriteLine(bla);
        GenericList<int> newBla = new GenericList<int>(10);
        for (int i = 0; i < 10; i++)
        {
            newBla.Add(i);
        }
        Console.WriteLine(newBla);
        newBla.Insert(10, 10);
        Console.WriteLine(newBla);
    }
}
