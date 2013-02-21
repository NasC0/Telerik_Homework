using System;

class FirstHigherNeighbour
{
    static int ArrayChecker(int[] array)
    {
        int position = -1;
        if (array.Length <= 1)
        {
            Console.WriteLine("There are no neighbours to check");
            return position;
        }
        if (array.Length > 1)
        {
            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i] > array[i - 1] && array[i] > array[i + 1])
                {
                    Console.WriteLine("The number {0} on position {1} is higher than both his neighbours", array[i], i);
                    position = i;
                    break;
                }
            }
        }
        return position;
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
        int index = ArrayChecker(array);
    }
}
