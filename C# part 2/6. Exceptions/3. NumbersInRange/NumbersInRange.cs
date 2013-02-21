using System;

class NumbersInRange
{
    static int ReadNumber(int start, int end)
    {
        int n = int.Parse(Console.ReadLine());
        if ((n <= start && n != 0)|| n > end)
        {
            throw new ArgumentOutOfRangeException("The number must be in the given range!");
        }
        else
        {
            return n;
        }
    }

    static void Main()
    {
        try
        {
            Console.WriteLine("Enter your numbers in ascending order in the range of [0....100]");
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                if (i == 0)
                {
                    array[i] = ReadNumber(0, 100);
                }
                else
                {
                    array[i] = ReadNumber(array[i - 1], 100);
                }
            }
        }
        catch (ArgumentOutOfRangeException outOfRange)
        {
            Console.WriteLine(outOfRange.Message);
        }
        catch (FormatException fe)
        {
            Console.WriteLine(fe.Message);
        }
    }
}
