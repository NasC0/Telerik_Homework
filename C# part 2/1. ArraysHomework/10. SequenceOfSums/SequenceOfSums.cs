using System;
using System.Collections.Generic;

class SequenceOfSums
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

        Console.WriteLine("What is the sum you are looking for?");
        int sum = int.Parse(Console.ReadLine());
        List<int> sequenceHolder = new List<int>();
        int currentSum = 0, endHolder = 0, leftElement = 0;
        for (int i = 0; i < arraySize; i++)
        {
            currentSum += sequenceArray[i];
            while (currentSum > sum)
            {
                currentSum -= sequenceArray[leftElement];
                leftElement++;
            }
            if (currentSum == sum)
            {
                endHolder = i;
                break;
            }
        }

        int textCount = 0;
        if (currentSum == sum)
        {
            Console.Write("The sequence with the desired sum {0} is: {{", currentSum);
            for (int i = leftElement; i <= endHolder; i++)
            {
                sequenceHolder.Add(sequenceArray[i]);
                if (endHolder - i == 0)
                {
                    Console.Write(sequenceHolder[textCount]);
                }
                else
                {
                    Console.Write(sequenceHolder[textCount] + ", ");
                }
                textCount++;
            }
            Console.WriteLine("}");
        }
        else
        {
            Console.WriteLine("No matches found");
        }
    }
}
