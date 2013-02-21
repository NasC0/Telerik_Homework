using System;

class MaximalSum
{
    static void Main()
    {
        int[,] array = 
        {
           { 0, 2, 4, 0, 9, 5 },
           { 7, 1, 3, 3, 2, 1 },
           { 1, 3, 9, 8, 5, 6 },
           { 4, 6, 7, 9, 1, 0 },
        };
        int bestSum = 0;
        for (int row = 0; row < array.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < array.GetLength(1) - 2; col++)
            {
                int sum = array[row, col] + array[row, col + 1] + array[row + 1, col + 1]
                    + array[row + 1, col + 2] + array[row + 2, col + 1] + array[row + 2, col + 2]
                    + array[row + 1, col];
                if (bestSum < sum)
                {
                    bestSum = sum;
                }
            }
        }
        Console.WriteLine(bestSum);
    }
}
