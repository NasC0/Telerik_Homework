using System;
using System.Collections.Generic;

class MaximalSum
{
    static void Main()
    {
        Console.WriteLine("Enter the size (N) of your array: ");         
        int arraySize = int.Parse(Console.ReadLine());                   
        int[] sequenceArray = new int[arraySize];                        
        Console.WriteLine("Populate your array");           
             
        for (int i = 0; i < sequenceArray.Length; i++)                   
        {                                                                
            sequenceArray[i] = int.Parse(Console.ReadLine());            
        }                                                                
        Console.Write("Enter K (must be K < N): ");                      
        int k = int.Parse(Console.ReadLine());                           
        int currentSum = 0;                                              // Initialise the variable needed to find the current sum
        int highestSum = 0;                                              // Holder for the highest sum
        int highestSumStart = 0;                                         // Starting position of the sequence with the highest sum
        List<int> highestSequence = new List<int>();                     // Adding the list that keeps the highest sum

        for (int i = 0; i < sequenceArray.Length - (k - 1); i++)         // Iterating through the original sequence with a stop at the size of the array - (k - 1)
        {
            for (int j = i; j < k + i; j++)                              // Separating the array into consecutive smaller pieces with size K
            {
                currentSum += sequenceArray[j];                          // Calculating the current sum of the smaller sequence
                if (currentSum >= highestSum)                            // Checking if the current sum is higher than the last Highest Sum
                {
                    highestSum = currentSum;                             // If it is higher, reinitialise the highestSum holder to the currentSum
                    highestSumStart = (k + (i - 1) - (k - 1));           // Setting the starting point holder for the Highest Sum List
                }
            }
            currentSum = 0;                                              // Resetting the current sum for the next iteration over both the whole array and the smaller one
        }
        Console.Write("The sequence with the highest sum is: {");

        for (int i = 0; i < k; i++)                                      // Setting the Highest Sum list to incorporate the Highest Sum Sequence
        {
            highestSequence.Add(sequenceArray[highestSumStart + i]);     // Adding each element
            if (k - i == 1)
            {
                Console.Write(highestSequence[i]);                       // Console text formatting
            }
            else
            {
                Console.Write(highestSequence[i] + ", ");
            }
        }
        Console.WriteLine("}");
        Console.WriteLine("The highest sum is: {0}", highestSum);
    }
}
