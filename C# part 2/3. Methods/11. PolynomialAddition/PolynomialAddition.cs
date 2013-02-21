using System;
using System.Collections.Generic;

class PolynomialAddition
{
    static int[] CreatePolynomial(int size)
    {
        int[] polynomial = new int[size];
        Console.WriteLine("You must add your elements in descending order of their power");
        for (int i = 0; i < size; i++)
        {
            Console.Write("Enter the {0} element: ", i + 1);
            polynomial[i] = int.Parse(Console.ReadLine());
        }
        Array.Reverse(polynomial);
        return polynomial;
    }

    static List<int> AddPolynoms(int[] firstPolynomial, int[] secondPolynomial)
    {
        List<int> newPolynom = new List<int>();
        if (firstPolynomial.Length >= secondPolynomial.Length)
        {
            for (int i = 0; i < firstPolynomial.Length; i++)
			{
                if (i >= secondPolynomial.Length)
	            {
                    newPolynom.Add(firstPolynomial[i]);
	            }
                else
                {
                    newPolynom.Add(firstPolynomial[i] + secondPolynomial[i]);
                }
			}
        }
        else
        {
            for (int i = 0; i < secondPolynomial.Length; i++)
			{
                if (i >= firstPolynomial.Length)
	            {
                    newPolynom.Add(secondPolynomial[i]);
	            }
                else
                {
                    newPolynom.Add(firstPolynomial[i] + secondPolynomial[i]);
                }
			}
        }
        PrintPolynom(firstPolynomial, secondPolynomial, newPolynom);
        return newPolynom;
    }

    static void PrintPolynom(int[] firstArray, int[] secondArray, List<int> array)
    {
        for (int i = 0; i < firstArray.Length; i++)
        {
            if (i == 0)
	        {
                Console.Write("{0} + ", firstArray[i]);
	        }
            else if(i == 1)
            {
                Console.Write("{0}x + ", firstArray[i]);
            }
            else if (i == firstArray.Length - 1)
            {
                Console.WriteLine("{0}x^{1} = 0    | +", firstArray[i], i);
            }
            else
            {
                Console.Write("{0}x^{1} + ", firstArray[i], i);
            }
        }

        for (int i = 0; i < secondArray.Length; i++)
        {
            if (i == 0)
            {
                Console.Write("{0} + ", secondArray[i]);
            }
            else if (i == 1)
            {
                Console.Write("{0}x + ", secondArray[i]);
            }
            else if (i == secondArray.Length - 1)
            {
                Console.WriteLine("{0}x^{1} = 0    | =", secondArray[i], i);
            }
            else
            {
                Console.Write("{0}x^{1} + ", secondArray[i], i);
            }
        }

        for (int i = 0; i < array.Count; i++)
        {
            if (i == 0)
            {
                Console.Write("{0} + ", array[i]);
            }
            else if (i == 1)
            {
                Console.Write("{0}x + ", array[i]);
            }
            else if (i == array.Count - 1)
            {
                Console.WriteLine("{0}x^{1} = 0", array[i], i);
            }
            else
            {
                Console.Write("{0}x^{1} + ", array[i], i);
            }
        }
    }

    static void Main()
    {
        Console.Write("Enter the number of coefficients in the first array: ");
        int firstSize = int.Parse(Console.ReadLine());
        int[] firstArray = CreatePolynomial(firstSize);
        Console.Write("Enter the number of coefficients in the second array: ");
        int secondSize = int.Parse(Console.ReadLine());
        int[] secondArray = CreatePolynomial(secondSize);
        List<int> array = AddPolynoms(firstArray, secondArray);
    }
}
