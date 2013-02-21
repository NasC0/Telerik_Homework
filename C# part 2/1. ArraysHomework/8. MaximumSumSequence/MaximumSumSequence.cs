using System;
using System.Collections.Generic;

/* Using Kadane's Algorithm
 * http://en.wikipedia.org/wiki/Maximum_subarray_problem */

class MaximumSumSequence
{
    static void Main()
    {
        Console.WriteLine("Enter the size of your array: ");
        int arraySize = int.Parse(Console.ReadLine());
        int[] sequenceArray = new int[arraySize];
        Console.WriteLine("Populate your array");

        for (int i = 0; i < sequenceArray.Length; i++)
        {
            sequenceArray[i] = int.Parse(Console.ReadLine());
        }

        List<int> highestSequence = new List<int>();
        int currentSum = 0, highestSum = 0, highestSumStart = 0, startHolder = 0, highestSumEnd = 0;
        for (int i = 0; i < arraySize; i++)
        {
            currentSum += sequenceArray[i];
            if (sequenceArray[i] > currentSum)
            {
                currentSum = sequenceArray[i];
                startHolder = i;
            }

            if (currentSum > highestSum)
            {
                highestSum = currentSum;
                highestSumStart = startHolder;
                highestSumEnd = i;
            }
        }

        int textCounter = 0;
        Console.Write("The sequence with the highest sum is: {");
        while (highestSumStart <= highestSumEnd)
        {
            highestSequence.Add(sequenceArray[highestSumStart]);
            if (highestSumEnd - highestSumStart == 0)
            {
                Console.Write(highestSequence[textCounter]);                       
            }
            else
            {
                Console.Write(highestSequence[textCounter] + ", ");
            }

            textCounter++;
            highestSumStart++;
        }

        Console.WriteLine("}");
        Console.WriteLine("The highest sequence sum is: {0}", highestSum);
    }
}