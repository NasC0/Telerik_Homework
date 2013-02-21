using System;
using System.Collections.Generic;

class MaximalSequence
{
    static void Main()
    {
        Console.WriteLine("Enter the size of the array: ");
        int size = int.Parse(Console.ReadLine());
        int[] array = new int[size];
        Console.WriteLine("Populate your array: ");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int count = 1;
        int maximumCount = 1;
        int elementValue = 0;
        List<int> intList = new List<int>();
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] == array[i - 1])
            {
                count++;
            }
            else if (array[i] != array[i - 1])
            {
                count = 1;
            }

            if (count >= maximumCount)
            {
                maximumCount = count;
                elementValue = array[i - 1];
            }
        }

        for (int i = 0; i < maximumCount; i++)
        {
            intList.Add(elementValue);
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
