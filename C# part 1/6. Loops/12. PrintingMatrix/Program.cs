using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter the size of your matrix: ");
        int size = Int32.Parse(Console.ReadLine());
        for (int rows = 1; rows <= size; rows++)
        {
            for (int cols = rows; cols <= rows + size - 1; cols++)
            {
                Console.Write(cols + " ");
            }
            Console.WriteLine();
        }
    }
}
