using System;

class ComparingArrays
{
    static void Main()
    {
        Console.WriteLine("Enter the size of the arrays: ");
        int size = int.Parse(Console.ReadLine());
        int[] firstArray = new int[size];
        int[] secondArray = new int[size];
        for (int i = 0; i < firstArray.Length; i++)
        {
            Console.Write("First array {0}nth number: ", (i+1));
            firstArray[i] = int.Parse(Console.ReadLine());
            Console.Write("Second array {0}nth number: ", (i+1));
            secondArray[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------");
        }

        for (int i = 0; i < firstArray.Length; i++)
        {
            if (firstArray[i] == secondArray[i])
            {
                Console.WriteLine("The numbers at position {0} are the same", (i + 1));
            }
            else
            {
                Console.WriteLine("The numbers at position {0} are not the same", (i + 1));
            }
        }
    }
}
