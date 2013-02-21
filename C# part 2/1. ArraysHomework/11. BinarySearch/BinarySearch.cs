using System;
class BinarySearch
{
    static void Main()
    {
        Console.WriteLine("Enter the size of your array: ");
        int size = int.Parse(Console.ReadLine());
        int[] array = new int[size];
        Console.WriteLine("Populate your array: ");
        for (int i = 0; i < size; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("What do you want to find?");
        int searchIndex = int.Parse(Console.ReadLine());
        int temp = 0, minValue = 0;
        for (int i = 0; i < size - 1; i++)                                                      
        {
            minValue = i;
            for (int j = i + 1; j < size; j++)
            {
                if (array[j] < array[minValue])
                {
                    minValue = j;
                }
            }

            temp = array[minValue];
            array[minValue] = array[i];
            array[i] = temp;
        }

        int midPoint = 0, minimalStart = 0, maximalStart = 0, indexHolder = 0;
        midPoint = size / 2;

        if (array[midPoint] > searchIndex)
        {
            for (int i = 0; i < midPoint; i++)
            {
                if (array[i] == searchIndex)
                {
                    indexHolder = i;
                    break;
                }
            }
        }
        else
        {
            for (int i = midPoint; i < size; i++)
            {
                if (array[i] == searchIndex)
                {
                    indexHolder = i;
                    break;
                }
            }
        }
        if (array[midPoint] == searchIndex)
        {
            Console.WriteLine(@"The number you wanted is array[{0}] = {1}", midPoint, array[midPoint]);
        }
        else if (array[indexHolder] == searchIndex )
        {
            Console.WriteLine(@"The number you wanted is array[{0}] = {1}", indexHolder, array[indexHolder]);
        }
        else
        {
            Console.WriteLine("Sorry, no result found");
        }
    }
}
