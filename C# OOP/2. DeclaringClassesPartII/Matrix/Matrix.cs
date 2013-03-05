using System;
using System.Text;

namespace Matrix.Common
{
    public class Matrix<T> where T : struct
    {
        private int rowSize;
        private int colSize;
        private T[,] matrix;

        public Matrix(int rowSize, int colSize)
        {
            this.rowSize = rowSize;
            this.colSize = colSize;
            this.matrix = new T[rowSize, colSize];
        }

        public static Matrix<T> operator +(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.colSize != secondMatrix.colSize || firstMatrix.rowSize != secondMatrix.rowSize)
            {
                throw new InvalidOperationException("The matrices rows and cols must be equal");
            }
            else if (firstMatrix.GetType() != secondMatrix.GetType())
            {
                throw new InvalidOperationException("The matrices must be of the same type");
            }
            else
            {
                Matrix<T> matrix = new Matrix<T>(firstMatrix.RowSize, firstMatrix.ColSize);
                for (int i = 0; i < matrix.RowSize; i++)
                {
                    for (int j = 0; j < matrix.ColSize; j++)
                    {
                        matrix[i, j] = (dynamic)firstMatrix[i, j] + (dynamic)secondMatrix[i, j];
                    }
                }
                return matrix;
            }
        }

        public static Matrix<T> operator -(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.colSize != secondMatrix.colSize || firstMatrix.rowSize != secondMatrix.rowSize)
            {
                throw new InvalidOperationException("The matrices rows and cols must be equal");
            }
            else if (firstMatrix.GetType() != secondMatrix.GetType())
            {
                throw new InvalidOperationException("The matrices must be of the same type");
            }
            else
            {
                Matrix<T> matrix = new Matrix<T>(firstMatrix.RowSize, firstMatrix.ColSize);
                for (int i = 0; i < matrix.RowSize; i++)
                {
                    for (int j = 0; j < matrix.ColSize; j++)
                    {
                        matrix[i, j] = (dynamic)firstMatrix[i, j] - (dynamic)secondMatrix[i, j];
                    }
                }
                return matrix;
            }
        }

        public static Matrix<T> operator *(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.colSize != secondMatrix.rowSize)
            {
                throw new InvalidOperationException("The first matrix' col number must be equal to the second matrix' row number");
            }
            else if (firstMatrix.GetType() != secondMatrix.GetType())
            {
                throw new InvalidOperationException("The matrices must be of the same type");
            }
            else
            {
                Matrix<T> matrix = new Matrix<T>(firstMatrix.RowSize, secondMatrix.ColSize);
                for (int i = 0; i < matrix.RowSize; i++)
                {
                    for (int j = 0; j < matrix.ColSize; j++)
                    {
                        matrix[i, j] = (dynamic)0;
                        for (int k = 0; k < firstMatrix.ColSize; k++)
                        {
                            matrix[i, j] = matrix[i, j] + (dynamic)firstMatrix[i, k] * (dynamic)secondMatrix[k, j];
                        }
                    }
                }
                return matrix;
            }
        }

        public static bool operator true(Matrix<T> matrix)
        {
            bool isTrue = true;
            for (int i = 0; i < matrix.RowSize; i++)
            {
                for (int j = 0; j < matrix.colSize; j++)
                {
                    if (matrix[i, j] == (dynamic)0)
                    {
                        isTrue = false;
                    }
                }
            }
            if (isTrue == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator false(Matrix<T> matrix)
        {
            bool isTrue = false;
            for (int i = 0; i < matrix.RowSize; i++)
            {
                for (int j = 0; j < matrix.colSize; j++)
                {
                    if (matrix[i, j] == (dynamic)0)
                    {
                        isTrue = false;
                    }
                }
            }
            if (isTrue == false)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < this.rowSize; i++)
            {
                for (int j = 0; j < this.colSize; j++)
                {
                    sb.Append(this.matrix[i, j]);
                    sb.Append(' ');
                }
                if (i != this.rowSize - 1)
                {
                    sb.AppendLine();
                }
            }
            return sb.ToString();
        }

        public int RowSize
        {
            get
            {
                return this.rowSize;
            }
        }

        public int ColSize
        {
            get
            {
                return this.colSize;
            }
        }

        public T this[int rowIndex, int colIndex]
        {
            get
            {
                if ((rowIndex < 0 || rowIndex >= this.rowSize) || (colIndex < 0 || colIndex >= this.colSize))
                {
                    throw new ArgumentOutOfRangeException("The index you requested was outside the boundaries of the matrix");
                }
                else
                {
                    return this.matrix[rowIndex, colIndex];
                }
            }
            set
            {
                this.matrix[rowIndex, colIndex] = value;
            }
        }
    }
}
