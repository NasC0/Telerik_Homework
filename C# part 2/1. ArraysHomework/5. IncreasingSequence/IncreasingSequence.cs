using System;
using System.Collections.Generic;

class IncreasingSequence
{
    static void Main()
    {
        Console.WriteLine("Enter the size of the array: ");
        int size = int.Parse(Console.ReadLine());
        int[] array = new int[size];

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("Enter the {0} number: ", i + 1);
            array[i] = int.Parse(Console.ReadLine());
        }
        int count = 1;
        int maximumCount = 1;
        int elementValue = 0;
        List<int> intList = new List<int>();
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] == (array[i - 1] + 1))
            {
                count++;
            }
            else if (array[i] != (array[i - 1] + 1))
            {
                count = 1;
            }
            if (count >= maximumCount)
            {
                maximumCount = count;
                elementValue = array[i - (maximumCount - 1)];
            }
        }
        for (int i = 0; i < maximumCount; i++)
        {
            if (i >= 1)
            {
                intList.Add(elementValue + i);
            }
            else
            {
                intList.Add(elementValue);
            }
        }
        Console.Write("The longest sequence is: {");
        for (int i = 0; i < intList.Count; i++)
        {
            if (intList.Count - i == 1)
            {
                Console.Write(intList[i]);
            }
            else
            {
                Console.Write(intList[i] + ", ");
            }
        }
        Console.WriteLine("}");
    }
}
