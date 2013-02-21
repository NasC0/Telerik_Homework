using System;

class FrequentNumberCounter
{
    static int Counter(int[] array, int number)
    {
        int counter = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == number)
            {
                counter++;
            }
        }
        if (counter == 0)
        {
            Console.WriteLine("Sorry the number you asked for does not exist in the array.");
        }
        else
        {
            Console.WriteLine("{0} instances of your desired number have been found", counter);
        }
        return counter;
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
        Console.Write("Which number do you want counted? ");
        int number = int.Parse(Console.ReadLine());
        int count = Counter(array, number);
    }
}
