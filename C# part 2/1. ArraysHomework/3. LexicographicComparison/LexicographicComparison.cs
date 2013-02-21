using System;

class LexicographicComparison
{
    static void Main()
    {
        Console.WriteLine("Enter the size of the arrays: ");
        int size = int.Parse(Console.ReadLine());
        char[] firstArray = new char[size];
        char[] secondArray = new char[size];
        for (int i = 0; i < firstArray.Length; i++)
        {
            Console.Write("First array {0}nth char: ", (i + 1));
            firstArray[i] = char.Parse(Console.ReadLine());
            Console.Write("Second array {0}nth char: ", (i + 1));
            secondArray[i] = char.Parse(Console.ReadLine());
            Console.WriteLine("-------------");
        }
        for (int i = 0; i < firstArray.Length; i++)
        {
            if (firstArray[i] == secondArray[i])
            {
                Console.WriteLine("The chars at position {0} are the same", (i + 1));
            }
            else
            {
                Console.WriteLine("The chars at position {0} are not the same", (i + 1));
            }
        }

    }
}
