using System;
using System.Collections.Generic;

class MatrixSequences
{
    static void Main()
    {
        string[,] sequences = 
        {
            { "s", "qq", "s" },
            { "pp", "pp", "s"},
            { "pp", "qq", "s"},
        };

        List<string> bestSeq = new List<string>();
        for (int row = 0; row < sequences.GetLength(0); row++)
        {
            for (int col = 0; col < sequences.GetLength(1); col++)
            {
                Console.Write(sequences[row, col] + " ");
            }
            Console.WriteLine();
        }

        int seq = 1, maxSeq = 0, tempRow = 1, tempCol = 0;
        for (int row = 0; row < sequences.GetLength(0); row++)
        {
            for (int col = 0; col < sequences.GetLength(1) - 1; col++)
            {
                if (sequences[row, col] == sequences[row, col + 1])
                {
                    seq++;
                }
                else
                {
                    seq = 1;
                }
                if (seq == maxSeq)
                {
                    bestSeq.Add(sequences[row, col]);
                }
                else if (seq > maxSeq)
                {
                    maxSeq = seq;
                    bestSeq.Clear();
                    bestSeq.Add(sequences[row, col]);
                }
            }
            seq = 1;
        }

        for (int col = 0; col < sequences.GetLength(1); col++)
        {
            for (int row = 0; row < sequences.GetLength(0) - 1; row++)
            {
                if (sequences[row, col] == sequences[row + 1, col])
                {
                    seq++;
                }
                else
                {
                    seq = 1;
                }
                if (seq == maxSeq)
                {
                    bestSeq.Add(sequences[row, col]);
                }
                else if (seq > maxSeq)
                {
                    maxSeq = seq;
                    bestSeq.Clear();
                    bestSeq.Add(sequences[row, col]);
                }
            }
            seq = 1;
        }

        for (int i = 0; i < sequences.GetLength(1) - 1; i++)
        {
            for (int row = 0, col = tempCol; row < sequences.GetLength(0) - 1 && col < sequences.GetLength(1) - 1; row++, col++)
            {
                if (sequences[row, col] == sequences[row + 1, col + 1])
                {
                    seq++;
                }
                else
                {
                    seq = 1;
                }
                if (seq == maxSeq)
                {
                    bestSeq.Add(sequences[row, col]);
                }
                else if (seq > maxSeq)
                {
                    maxSeq = seq;
                    bestSeq.Clear();
                    bestSeq.Add(sequences[row, col]);
                }
            }
            tempCol++;
            seq = 1;
        }

        for (int i = 0; i < sequences.GetLength(0) - 1; i++)
        {
            for (int row = tempRow, col = 0; row < sequences.GetLength(0) - 1 && col < sequences.GetLength(1) - 1; row++, col++)
            {
                if (sequences[row, col] == sequences[row + 1, col + 1])
                {
                    seq++;
                }
                else
                {
                    seq = 1;
                }
                if (seq == maxSeq)
                {
                    bestSeq.Add(sequences[row, col]);
                }
                else if (seq > maxSeq)
                {
                    maxSeq = seq;
                    bestSeq.Clear();
                    bestSeq.Add(sequences[row, col]);
                }
            }
            tempRow++;
            seq = 1;
        }


        Console.Write("The element with the biggest sequence is: ");
        for (int i = 0; i < bestSeq.Count; i++)
        {
            Console.Write(bestSeq[i] + " ");
        }
        Console.WriteLine();
    }
}