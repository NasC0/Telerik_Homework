using System;
using Matrix.Common;

class MatrixIndexTest
{
    static void Main()
    {
        Matrix<float> floatMatrix = new Matrix<float>(4, 4);
        float count = 0.5f;
        for (int i = 0; i < floatMatrix.RowSize; i++)
        {
            for (int j = 0; j < floatMatrix.ColSize; j++)
            {
                floatMatrix[i, j] = count;
                count++;
            }
        }
        for (int i = 0; i < floatMatrix.RowSize; i++)
        {
            for (int j = 0; j < floatMatrix.ColSize; j++)
            {
                Console.Write(floatMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
