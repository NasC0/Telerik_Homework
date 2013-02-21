using System;

namespace _14.PrintMatrixInSpiral
{
    class Program
    {
        static void Main()
        {
            int N;
            int counter = 0;
            int numberOfDoubleSections; //How many Row/Column sections has the spiral
            int spiralSectionLength; //Length of the spiral section ( row or column section)
            byte column = 0;
            byte row = 0;
            Console.Write("Enter an integer number < 20:");
            bool isnInt = int.TryParse(Console.ReadLine(), out N);
            if (isnInt & N < 20 & N > 0)
            {
                int[,] array = new int[N, N];
                for (column = 0; column < N; column++)//Fill the first row
                {
                    counter++;
                    array[row, column] = counter;
                }
                column--;
                numberOfDoubleSections = N - 1;
                spiralSectionLength = N - 1;
                counter++;
                for (int section = 0; section < numberOfDoubleSections; section++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        for (int i = 0; i < spiralSectionLength; i++)
                        {
                            if (j == 1)//Row printing
                            {
                                if (section % 2 == 0)// isLeftDirection
                                {
                                    column--;
                                    array[row, column] = counter;
                                }
                                else
                                {
                                    column++;
                                    array[row, column] = counter;
                                }
                            }
                            else //Column printing
                            {
                                if (section % 2 == 0)// isDownDirection
                                {
                                    row++;
                                    array[row, column] = counter;
                                }
                                else
                                {
                                    row--;
                                    array[row, column] = counter;
                                }
                            }
                            counter++;
                        }
                    }
                    spiralSectionLength--;
                }

                for (row = 0; row < N; row++)
                {
                    for (column = 0; column < N; column++)
                    {
                        Console.Write("{0,4}", array[row, column]);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Wrong entry!");
            }
        }
    }
}