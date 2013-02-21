using System;

class AlphabeticSort
{
    static void Main()
    {
        Console.Write("Enter the words you want sorted: ");
        string words = Console.ReadLine();
        string[] array = words.Split(' ');
        Array.Sort(array);
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
    }
}
