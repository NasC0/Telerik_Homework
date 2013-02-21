using System;
using System.Numerics;

class IntegerSequenceOperations
{
    static int[] ArrayCreator()
    {
        Console.WriteLine("Enter the size of your array: ");
        int size = int.Parse(Console.ReadLine());
        if (size < 1)
        {
            Console.WriteLine("The sequence must not be empty");
            return ArrayCreator();
        }
        int[] array = new int[size];
        Console.WriteLine("Populate your array: ");
        for (int i = 0; i < size; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        return array;
    }

    static void SortArray(int[] array)
    {
        int minimal = 0;
        int temp = 0;
        for (int i = 0; i < array.Length - 1; i++)
        {
            minimal = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[minimal])
                {
                    minimal = j;
                }
            }

            temp = array[minimal];
            array[minimal] = array[i];
            array[i] = temp;
        }
    }

    static int Maximum(params int[] array)
    {
        SortArray(array);
        int maximal = array[array.Length - 1];
        return maximal;
    }

    static int Minimum(params int[] array)
    {
        SortArray(array);
        int minimal = array[0];
        return minimal;
    }

    static int Average(params int[] array)
    {
        if (array.Length == 0)
        {
            Console.WriteLine("The sequence must not be empty!");
            Console.WriteLine("Returned average = 0. Restart the program to start over.");
            return 0;
        }
        else
        {
            int average = 0;
            for (int i = 0; i < array.Length; i++)
            {
                average += array[i];
            }
            average = average / array.Length;
            return average;
        }

    }

    static int ArraySummation(params int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum;
    }

    static BigInteger ArrayProduct(params int[] array)
    {
        BigInteger product = 1;
        for (int i = 0; i < array.Length; i++)
        {
            product *= array[i];
        }
        return product;
    }

    static void Main()
    {
        int[] array = ArrayCreator();
        int maximal = Maximum(array);
        int minimal = Minimum(array);
        int average = Average(array);
        int sum = ArraySummation(array);
        BigInteger product = ArrayProduct(array);
        Console.WriteLine();
        Console.WriteLine("The highest number is: {0}", maximal);
        Console.WriteLine("The smallest number is: {0}", minimal);
        Console.WriteLine("The average number is: {0}", average);
        Console.WriteLine("The sum is: {0}", sum);
        Console.WriteLine("The product is: {0}", product);
    }
}
