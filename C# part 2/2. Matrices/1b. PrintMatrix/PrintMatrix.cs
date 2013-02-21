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
            for (int col = 0; col < size; col++)
            {
                if (col == 0)
                {
                    for (int row = 0; row < size; row++)
                    {
                        matrix[row, col] = number;
                        number++;
                    }
                }
                else if (col % 2 != 0)
                {
                    for (int row = size - 1; row >= 0; row--)
                    {
                        matrix[row, col] = number;
                        number++;
                    }
                }
                else
                {
                    for (int row = 0; row < size; row++)
                    {
                        matrix[row, col] = number;
                        number++;
                    }
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
