using System;

class MaximalInSubarray
{
    static int MaximalArrayNumber(int[] array, int start, int end)
    {
        int tempStart = start;
        int[] tempArray = new int[(end - start) + 1];
        for (int i = 0; i < (end - start) + 1; i++)
        {
            tempArray[i] = array[tempStart];
            tempStart++;
        }
        SortArray(tempArray);
        int maximal = tempArray[tempArray.Length - 1];
        Console.WriteLine(maximal);
        return maximal;
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

    static int[] ArrayCreator()
    {
        Console.WriteLine("Enter the size of your array: ");
        int size = int.Parse(Console.ReadLine());
        int[] array = new int[size];
        Console.WriteLine("Populate your array: ");
        for (int i = 0; i < size; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        return array;
    }

    static void Main()
    {
        int[] array = ArrayCreator();
        Console.Write("Enter the starting position: ");
        int start = int.Parse(Console.ReadLine()) - 1;
        Console.Write("Enter the end position: ");
        int end = int.Parse(Console.ReadLine()) - 1;
        int maximal = MaximalArrayNumber(array, start, end);
    }
}
