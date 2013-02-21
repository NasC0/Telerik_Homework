using System;

class MostFrequentNumber
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

        int maxCount = 0, indexHolder = 0;
        int tempCount = 0;
        for (int i = 0; i < sequenceArray.Length; i++)
        {
            for (int j = 0; j < sequenceArray.Length; j++)
            {
                if (sequenceArray[j] == sequenceArray[i])
                {
                    tempCount++;
                }
            }

            if (tempCount >= maxCount)
            {
                maxCount = tempCount;
                indexHolder = i;
            }

            tempCount = 0;
        }

        Console.WriteLine("The most frequent number is {0} and it is repeated {1} times.", sequenceArray[indexHolder], maxCount);
    }
}
