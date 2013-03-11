using System;
using System.Linq;
using System.Collections.Generic;
using IntExtensions;

class IntDivisable
{
    static void Main()
    {
        List<int> list = new List<int>();
        for (int i = 1; i < 71; i++)
        {
            list.Add(i);
        }

        List<int> newList = list.FindAll(x => (x % 5 == 0 && x % 7 == 0));

        foreach (var item in newList)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();

        // LINQ operation
        var divisable =
            from num in list
            where num % 5 == 0 && num % 7 == 0
            select num;

        foreach (var num in divisable)
        {
            Console.WriteLine(num);
        }
    }
}
