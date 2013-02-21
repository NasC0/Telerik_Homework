using System;

class PrintMatrix
{
    static void Main()
    {
        Console.WriteLine("Enter matrix size (1 ... 20): ");
        int size = int.Parse(Console.ReadLine());
        if (size > 20 || size < 1)
        {
            Console.WriteLine("Please enter a size in the range (1...20)!");
            Main();
        }
        else
        {
            int[,] matrix = new int[size, size];
            int number = 1;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[col, row] = number;
                    number++;
                }
            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}