using System;
using Matrix.Common;

class MatrixTest
{
    static void Main()
    {
        Matrix<int> newMatrix = new Matrix<int>(5, 5);
        dynamic count = 0;
        for (int i = 0; i < newMatrix.RowSize; i++)
        {
            for (int j = 0; j < newMatrix.ColSize; j++)
            {
                newMatrix[i, j] = count;
                count++;
            }
        }
        Console.WriteLine(newMatrix.ToString());
        Console.WriteLine();
        Matrix<float> floatMatrix = new Matrix<float>(4, 4);
        count = 0.5f;
        for (int i = 0; i < floatMatrix.RowSize; i++)
        {
            for (int j = 0; j < floatMatrix.ColSize; j++)
            {
                floatMatrix[i, j] = count;
                count++;
            }
        }
        Console.WriteLine(floatMatrix.ToString());
    }
}
