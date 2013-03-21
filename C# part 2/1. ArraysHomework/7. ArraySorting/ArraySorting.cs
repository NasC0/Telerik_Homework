using System;

class ArraySorting
{
    static void Main()
    {
        int[] sequenceArray = 
        {
            5, 3, 2, 7, 0, 9, 4, 1, 6, 6, 2, 8   
        };

        int temp = 0, minValue = 0;
        for (int i = 0; i < sequenceArray.Length - 1; i++)
        {
            minValue = i;
            for (int j = i + 1; j < sequenceArray.Length; j++)
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
        for (int i = 0; i < sequenceArray.Length; i++)
        {
            Console.Write(sequenceArray[i] + " ");
        }
        Console.WriteLine();
    }
}
