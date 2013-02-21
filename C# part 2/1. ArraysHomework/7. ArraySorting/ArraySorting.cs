using System;

class ArraySorting
{
    static void Main()
    {
        Console.WriteLine("Enter the size of your array: ");
        int arraySize = int.Parse(Console.ReadLine());
        int[] sequenceArray = new int[arraySize];
        Console.WriteLine("Populate your array");

        for (int i = 0; i < arraySize; i++)
        {
            sequenceArray[i] = int.Parse(Console.ReadLine());
        }
        int temp = 0, minValue = 0;
        for (int i = 0; i < arraySize - 1; i++)
        {
            minValue = i;
            for (int j = i + 1; j < arraySize; j++)
            {
                if (sequenceArray[j] < sequenceArray[minValue])
                {
                    minValue = j;
                }
            }

            temp = sequenceArray[minValue];
            sequenceArray[minValue] = sequenceArray[i];
            sequenceArray[i] = temp;
        }

        Console.WriteLine("---------------------------");
        for (int i = 0; i < arraySize; i++)
        {
            Console.Write(sequenceArray[i] + " ");
        }
        Console.WriteLine();
    }
}
