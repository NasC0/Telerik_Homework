/* Implement a set of extension methods for IEnumerable<T> 
 * that implement the following group functions: sum, product, min, max, average. */

using System;
using System.Collections;
using System.Collections.Generic;

namespace IEnumerableExtension
{
    public static class Extensions
    {
        public static T Sum<T>(this IEnumerable<T> collection)
        {
            dynamic sum = 0;
            foreach (T item in collection)
            {
                sum += item;
            }
            return sum;
        }

        public static T Product<T>(this IEnumerable<T> collection)
        {
            dynamic product = 1;
            foreach (T item in collection)
            {
                product *= item;
            }
            return product;
        }

        public static T Min<T>(this IEnumerable<T> collection) where T : IComparable
        {
            dynamic min = int.MaxValue;
            foreach (T item in collection)
            {
                if (item < min)
                {
                    min = item;
                }
            }
            return min;
        }

        public static T Max<T>(this IEnumerable<T> collection) where T : IComparable
        {
            dynamic max = int.MinValue;
            foreach (T item in collection)
            {
                if (item > max)
                {
                    max = item;
                }
            }
            return max;
        }

        public static T Average<T>(this IEnumerable<T> collection)
        {
            dynamic sum = collection.Sum();
            dynamic count = 0;
            foreach (T item in collection)
            {
                count++;
            }
            return sum / count;
        }
    }
}
