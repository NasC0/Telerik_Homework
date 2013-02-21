using System;
using System.IO;

class GetMatrixSum
{
    static int[,] GetMatrix(string path)
    {
        StreamReader reader = new StreamReader(@"..\..\input.txt");
        using (reader)
        {
            string line = reader.ReadLine();
            int size = int.Parse(line);
            int[,] array = new int[size, size];
            line = reader.ReadLine();
            while (line != null)
            {

                for (int row = 0; row < array.GetLength(0); row++)
                {
                    string[] nums = line.Split();
                    for (int col = 0; col < array.GetLength(1); col++)
                    {
                        array[col, row] = int.Parse(nums[col]);
                    }
                    line = reader.ReadLine();
                }
            }
            return array;
        }
    }

    static int GetSum(int[,] matrix)
    {
        int highestSum = 0;
        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                int sum = matrix[row, col] + matrix[row, col + 1]
                    + matrix[row + 1, col] + matrix[row + 1, col + 1];
                if (highestSum < sum)
                {
                    highestSum = sum;
                }
            }
        }
        OutputResult(highestSum);
        return highestSum;
    }

    static void OutputResult(int sum)
    {
        try
        {
            StreamWriter writer = new StreamWriter(@"..\..\output.txt");
            using (writer)
            {
                writer.WriteLine(sum);
            }
        }
        catch (IOException ioEx)
        {
            Console.WriteLine(ioEx.Message);
        }
    }

    static void Main()
    {
        int[,] array = GetMatrix(@"..\..\input.txt");
        int size = GetSum(array);
    }
}
