using System;
using System.Collections.Generic;

class MultiTypeSequenceOperations
{

    static void SortArray<T>(T[] array)
    {
        dynamic minimal = 0;
        dynamic temp = 0;
        for (int i = 0; i < array.Length - 1; i++)
        {
            minimal = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if ((dynamic)array[j] < (dynamic)array[minimal])
                {
                    minimal = j;
                }
            }

            temp = array[minimal];
            array[minimal] = array[i];
            array[i] = temp;
        }
    }

    static T Maximum<T>(params T[] array)
    {
        if (array.Length == 0)
        {
            Console.WriteLine("The sequence must not be empty!");
            Console.WriteLine("Returned maximal = 0. Restart the program to start over.");
            dynamic number = 0;
            return number;
        }
        if (array.GetType() == typeof(string))
        {
            Console.WriteLine("The sequence you enter cannot be of string or char type");
            Console.WriteLine("Returned maximal = 0. Restart the program to start over.");
            dynamic maximal = '0';
            return maximal;
        }
        else if (array[0].GetType() == typeof(char))
        {
            Console.WriteLine("The sequence you enter cannot be of string or char type");
            Console.WriteLine("Returned maximal = 0. Restart the program to start over.");
            dynamic maximal = '0';
            return maximal;
        }
        else
        {
            dynamic maximal = array[array.Length - 1];
            return maximal;
        }
    }

    static T Minimum<T>(params T[] array)
    {
        if (array.Length == 0)
        {
            Console.WriteLine("The sequence must not be empty!");
            Console.WriteLine("Returned minimal = 0. Restart the program to start over.");
            dynamic number = 0;
            return number;
        }
        if (array.GetType() == typeof(string))
        {
            Console.WriteLine("The sequence you enter cannot be of string or char type");
            Console.WriteLine("Returned minimal = 0. Restart the program to start over.");
            dynamic minimal = '0';
            return minimal;
        }
        else if (array[0].GetType() == typeof(char))
        {
            Console.WriteLine("The sequence you enter cannot be of string or char type");
            Console.WriteLine("Returned minimal = 0. Restart the program to start over.");
            dynamic minimal = '0';
            return minimal;
        }
        else
        {
            dynamic minimal = array[0];
            return minimal;
        }
    }

    static T Average<T>(params T[] array)
    {
        if (array.Length == 0)
        {
            Console.WriteLine("The sequence must not be empty!");
            Console.WriteLine("Returned average = 0. Restart the program to start over.");
            dynamic number = 0;
            return number;
        }
        if (array.GetType() == typeof(string))
        {
            Console.WriteLine("The sequence you enter cannot be of string or char type");
            Console.WriteLine("Returned average = 0. Restart the program to start over.");
            dynamic average = '0';
            return average;
        }
        else if (array[0].GetType() == typeof(char))
        {
            Console.WriteLine("The sequence you enter cannot be of string or char type");
            Console.WriteLine("Returned average = 0. Restart the program to start over.");
            dynamic average = '0';
            return average;
        }
        else
        {
            dynamic average = 0;
            for (int i = 0; i < array.Length; i++)
            {
                average += array[i];
            }
            average = average / array.Length;
            return average;
        }

    }

    static T ArraySummation<T>(params T[] array)
    {
        if (array.Length == 0)
        {
            Console.WriteLine("The sequence must not be empty!");
            Console.WriteLine("Returned sum = 0. Restart the program to start over.");
            dynamic number = 0;
            return number;
        }
        if (array.GetType() == typeof(string))
        {
            Console.WriteLine("The sequence you enter cannot be of string or char type");
            Console.WriteLine("Returned sum = 0. Restart the program to start over.");
            dynamic sum = "0";
            return sum;
        }
        else if (array[0].GetType() == typeof(char))
        {
            Console.WriteLine("The sequence you enter cannot be of string or char type");
            Console.WriteLine("Returned sum = 0. Restart the program to start over.");
            dynamic sum = '0';
            return sum;
        }
        else
        {
            dynamic sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
    }

    static T ArrayProduct<T>(params T[] array)
    {
        if (array.Length == 0)
        {
            Console.WriteLine("The sequence must not be empty!");
            Console.WriteLine("Returned product = 0. Restart the program to start over.");
            dynamic number = 0;
            return number;
        }
        if (array.GetType() == typeof(string))
        {
            Console.WriteLine("The sequence you enter cannot be of string or char type");
            Console.WriteLine("Returned product = 0. Restart the program to start over.");
            dynamic product = "0";
            return product;
        }
        else if (array[0].GetType() == typeof(char))
        {
            Console.WriteLine("The sequence you enter cannot be of string or char type");
            Console.WriteLine("Returned product = 0. Restart the program to start over.");
            dynamic product = '0';
            return product;
        }
        else
        {
            dynamic product = 1;
            for (int i = 0; i < array.Length; i++)
            {
                product *= array[i];
            }
            return product;
        }
        
    }

    static void Main()
    {
        float[] array = { 0.5f, 3.1f, 3.2f, 3.0f, 3.4f, 8f };
        Console.WriteLine("The minimal number of the array: {0}", Minimum(array));
        Console.WriteLine("The maximal number of the array: {0}", Maximum(array));
        Console.WriteLine("The Average of the array: {0 : 0.0}", Average(array));
        Console.WriteLine("The sum of the array: {0 : 0.0}", ArraySummation(array));
        Console.WriteLine("The product of the array: {0 : 0.0}", ArrayProduct(array));
    }
}