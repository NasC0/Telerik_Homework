using System;

class IndexMultiplication
{
    static void Main()
    {
        int[] newArray = new int[20];
        for (int i = 0; i < newArray.Length; i++)
        {
            newArray[i] = i * 5;
            Console.WriteLine(newArray[i]);
        }
    }
}