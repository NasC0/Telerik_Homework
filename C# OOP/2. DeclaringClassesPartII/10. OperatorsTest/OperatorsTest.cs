using System;
using Matrix.Common;

class OperatorsTest
{
    static void Main()
    {
        Matrix<int> firstMatrix = new Matrix<int>(4, 4);
        Matrix<int> secondMatrix = new Matrix<int>(4, 4);
        int count = 2;

        for (int i = 0; i < firstMatrix.RowSize; i++)
        {
            for (int j = 0; j < firstMatrix.ColSize; j++)
            {
                firstMatrix[i, j] = count;
                secondMatrix[i, j] = count;
                count++;
            }
        }

        Matrix<int> combined = firstMatrix + secondMatrix;
        Console.WriteLine(combined.ToString());
        Console.WriteLine();
        Matrix<int> subtracted = combined - firstMatrix;
        Console.WriteLine(subtracted.ToString());

        firstMatrix = new Matrix<int>(3, 3);
        secondMatrix = new Matrix<int>(3, 2);
        count = 1;
        for (int i = 0; i < firstMatrix.RowSize; i++)
        {
            for (int j = 0; j < firstMatrix.ColSize; j++)
            {
                firstMatrix[i, j] = count;
                count++;
            }
        }

        count = 1;
        for (int i = 0; i < secondMatrix.RowSize; i++)
        {
            for (int j = 0; j < secondMatrix.ColSize; j++)
            {
                secondMatrix[i, j] = count;
                count++;
            }
        }
        Console.WriteLine(firstMatrix.ToString());
        Console.WriteLine(secondMatrix.ToString());

        Console.WriteLine();

        Matrix<int> multiplied = firstMatrix * secondMatrix;
        Console.WriteLine(multiplied.ToString());

        if (multiplied)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }

        Matrix<int> boolCheck = new Matrix<int>(2, 3);
        boolCheck[0, 0] = 0;

        if (boolCheck)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }
}
