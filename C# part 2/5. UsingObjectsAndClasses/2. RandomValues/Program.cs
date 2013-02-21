using System;

class Program
{
    static Random valueGenerator = new Random();

    static int[] GenerateValue()
    {
        int[] array = new int[10];
        for (int i = 0; i < 10; i++)
        {
            array[i] = valueGenerator.Next(100, 200);
        }
        return array;
    }

    static void Main()
    {
        int[] array = GenerateValue();
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
}
