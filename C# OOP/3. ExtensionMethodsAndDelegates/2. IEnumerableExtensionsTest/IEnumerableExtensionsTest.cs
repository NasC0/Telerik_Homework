/* Implement a set of extension methods for IEnumerable<T> 
 * that implement the following group functions: sum, product, min, max, average. */

using System;
using System.Collections.Generic;
using IEnumerableExtension;

class IEnumerableExtensionsTest
{
    static void Main()
    {
        List<int> test = new List<int>();
        for (int i = 1; i <= 11; i++)
        {
            test.Add(i);
        }
        int sum = test.Sum();
        int min = test.Min();
        int max = test.Max();
        int product = test.Product();
        int average = test.Average();
        Console.WriteLine("The sum is: {0}", sum);
        Console.WriteLine("The min is: {0}", min);
        Console.WriteLine("The max is: {0}", max);
        Console.WriteLine("The product is: {0}", product);
        Console.WriteLine("The average is: {0}", average);
    }
}
