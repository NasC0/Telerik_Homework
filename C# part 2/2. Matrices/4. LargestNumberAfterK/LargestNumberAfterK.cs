using System;

class LargestNumberAfterK
{
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
        Console.WriteLine("Enter the k element: ");
        int k = int.Parse(Console.ReadLine());
        Array.Sort(array);
        int number = Array.BinarySearch(array, k);
        if (number < -1)
        {
            Console.WriteLine("The highest number after {0} is: {1}", k, array[~number - 1]);
        }
        else if (~number == 0)
        {
            Console.WriteLine("No number lower than {0}!", k);
        }
        else
        {
            Console.WriteLine("The highest number after {0} is: {1}", k, array[number]);
        }
    }
}
