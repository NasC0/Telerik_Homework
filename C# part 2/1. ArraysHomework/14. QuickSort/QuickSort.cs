using System;
using System.Collections.Generic;
using System.Linq;

class QuickSorter
{
    static List<string> QuickSort(List<string> str)
    {
        List<string> left = new List<string>();
        List<string> right = new List<string>();
        if (str.Count > 0)
        {
            int pivot = str.Count / 2;
            string pivotStr = str[pivot];
            for (int i = 0; i < str.Count; i++)
            {
                if (i != pivot)
                {
                    if (string.Compare(str[i], str[pivot]) >= 0)
                    {
                        right.Add(str[i]);
                    }
                    else
                    {
                        left.Add(str[i]);
                    }
                }
            }

            left = QuickSort(left);
            right = QuickSort(right);
            str.Clear();
            str.AddRange(left);
            str.Add(pivotStr);
            str.AddRange(right);
        }
        return str;
    }

    static void Main()
    {
        string[] stringArray = { "ada", "dsds", "erwer", "ftrete", "test", "aa" };
        List<string> newList = stringArray.ToList();
        newList = QuickSort(newList);
        foreach (var item in newList)
        {
            Console.WriteLine(item);
        }
    }
}
