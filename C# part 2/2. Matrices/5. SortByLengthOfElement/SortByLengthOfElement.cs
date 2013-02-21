using System;
using System.Collections.Generic;

class SortByLengthOfElement
{
    static void SortByLength(string[] array)
    {
        int[] lengthHolder = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            lengthHolder[i] = array[i].Length;
        }
        Array.Sort(lengthHolder, array);
    }

    static void Main()
    {
        string[] array = { "haha", "ha", "h", "bah" };
        SortByLength(array);
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
}
