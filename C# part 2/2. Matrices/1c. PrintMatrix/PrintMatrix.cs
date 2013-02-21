using System;

class PrintMatrix
{
    static void Main()
    {
        Console.Write("Enter matrix size (1 ... 20): ");
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
            for (int row = 0; row <= size - 1; row++)
            {
                for (int col = 0; col <= row; col++)
                {
                    matrix[size - row + col - 1, col] = number;
                    number++;
                }
            }

            for (int row = size - 2; row >= 0; row--)
            {
                for (int col = row; col >= 0; col--)
                {
                    matrix[row - col, size - col - 1] = number;
                    number++;
                }
            }

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
