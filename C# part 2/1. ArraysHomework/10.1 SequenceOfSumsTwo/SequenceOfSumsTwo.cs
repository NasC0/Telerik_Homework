using System;
using System.Collections.Generic;

class SequenceOfSumsTwo
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
            for (int j = 0; j < arraySize; j++)
            {
                currentSum += sequenceArray[j];
                if (currentSum == sum)
                {
                    leftElement = i;
                    endHolder = j;
                    break;
                }
            }
            if (currentSum == sum)
            {
                break;
            }
        }
        Console.WriteLine(currentSum);
        //int textCount = 0;
        //Console.Write("The sequence with the highest sum is: {");
        //for (int i = leftElement; i <= endHolder; i++)
        //{
        //    sequenceHolder.Add(sequenceArray[i]);
        //    if (endHolder - i == 0)
        //    {
        //        Console.Write(sequenceHolder[textCount]);
        //    }
        //    else
        //    {
        //        Console.Write(sequenceHolder[textCount] + ", ");
        //    }
        //    textCount++;
        //}
        //Console.WriteLine("}");
    }
}

