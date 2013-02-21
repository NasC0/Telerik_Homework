using System;
class ArrayNumberChecker
{
    static void ArrayChecker(int[] array, int position)
    {
        if (array.Length == 0)
        {
            Console.WriteLine("There are no neighbours to check");
        }
        if (position >= 1 && array.Length > 1)
        {
            if (array[position] > array[position - 1] && array[position] > array[position + 1])
            {
                Console.WriteLine("The number on the position you wanted is higher than both his neighbours");
            }
            else if (array[position - 1] > array[position] && array[position + 1] > array[position])
            {
                Console.WriteLine("Both of the number's neighbours are higher than it");
            }
            else if (array[position - 1] > array[position])
            {
                Console.WriteLine("The left neighbour of the number is higher than it");
            }
            else if ((array[position + 1] > array[position]))
            {
                Console.WriteLine("The right neighbour of the number is higher than it");
            }
        }
        else
        {
            Console.WriteLine("Sorry, the position you choose must be higher than the starting index of the array");
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
        Console.WriteLine("Enter the position you want checked: ");
        int position = int.Parse(Console.ReadLine());
        ArrayChecker(array, position);
    }
}
