using System;

class SubsetPermutations
{
    //static int N = int.Parse(Console.ReadLine());
    static void Permutations(int[] array, int element, int arraySize)
    {
        if (element == array.Length)
        {
            Print(array);
        }
        else
        {
            for (int i = 0; i < arraySize; i++)
            {
                array[element] = i+1;
                Permutations(array, element + 1, arraySize);
            }
        }
    }

    static void Print(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("{0} ", array[i]);
        }
        Console.WriteLine();
    }

    static void Main()
    {
        Console.WriteLine("Enter the size of the array: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the K element: ");
        int k = int.Parse(Console.ReadLine());
        int[] array = new int[k];
        Permutations(array, 0, n);
    }
}
