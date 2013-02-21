using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter the size of the spiral matrix: ");
        int size = Int32.Parse(Console.ReadLine());
        int counter = 1;
        if (size <= 0 || size >= 20)
        {
            Console.WriteLine("The size of the matrix must be in the 1 < size < 20 range!");
            return;
        }
        else
        {
            int[,] spiral = new int[size + 1, size * size];
            for (int rows = 1; rows <= size; rows++)
            {
                for (int cols = 1; cols <= size; cols++)
                {
                    spiral[rows, cols] = counter;
                    counter++;
                    Console.Write("{0, 5}", spiral[rows, cols]);
                }
                Console.WriteLine();
            }
        }
    }
}
