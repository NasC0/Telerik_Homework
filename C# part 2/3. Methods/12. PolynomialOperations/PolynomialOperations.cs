using System;
using System.Collections.Generic;

class PolynomialOperations
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

    static List<int> SubtractPolynomials(int[] firstPolynom, int[] secondPolynom)
    {
        List<int> newPolynom = new List<int>();
        if (firstPolynom.Length >= secondPolynom.Length)
        {
            for (int i = 0; i < firstPolynom.Length; i++)
            {
                if (i >= secondPolynom.Length)
                {
                    newPolynom.Add(firstPolynom[i]);
                }
                else
                {
                    newPolynom.Add(firstPolynom[i] - secondPolynom[i]);
                }
            }
        }
        else
        {
            for (int i = 0; i < secondPolynom.Length; i++)
            {
                if (i >= firstPolynom.Length)
                {
                    newPolynom.Add(secondPolynom[i]);
                }
                else
                {
                    newPolynom.Add(firstPolynom[i] + secondPolynom[i]);
                }
            }
        }
        PrintPolynom(firstPolynom, secondPolynom, newPolynom);
        return newPolynom;
    }

    static int[] MultiplyPolynoms(int[] firstArray, int[] secondArray)
    {
        int[] polynom = new int[firstArray.Length + secondArray.Length - 1];
        for (int i = 0; i < firstArray.Length; i++)
        {
            for (int j = 0; j < secondArray.Length; j++)
            {
                polynom[i + j] += firstArray[i] * secondArray[j];
            }

        }
        PrintPolynom(firstArray, secondArray, polynom);
        return polynom;
    }

    static void PrintPolynom(int[] firstArray, int[] secondArray, List<int> array)
    {
        for (int i = 0; i < firstArray.Length; i++)
        {
            if (i == 0)
            {
                Console.Write("{0} + ", firstArray[i]);
            }
            else if (i == 1)
            {
                Console.Write("{0}x + ", firstArray[i]);
            }
            else if (i == firstArray.Length - 1)
            {
                Console.WriteLine("{0}x^{1} = 0", firstArray[i], i);
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
                Console.WriteLine("{0}x^{1} = 0", secondArray[i], i);
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

    static void PrintPolynom(int[] firstArray, int[] secondArray, int[] array)
    {
        for (int i = 0; i < firstArray.Length; i++)
        {
            if (i == 0)
            {
                Console.Write("{0} + ", firstArray[i]);
            }
            else if (i == 1)
            {
                Console.Write("{0}x + ", firstArray[i]);
            }
            else if (i == firstArray.Length - 1)
            {
                Console.WriteLine("{0}x^{1} = 0", firstArray[i], i);
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
                Console.WriteLine("{0}x^{1} = 0", secondArray[i], i);
            }
            else
            {
                Console.Write("{0}x^{1} + ", secondArray[i], i);
            }
        }

        for (int i = 0; i < array.Length; i++)
        {
            if (i == 0)
            {
                Console.Write("{0} + ", array[i]);
            }
            else if (i == 1)
            {
                Console.Write("{0}x + ", array[i]);
            }
            else if (i == array.Length - 1)
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
        Console.WriteLine("Adding polynomials: ");
        List<int> firstPolynom = AddPolynoms(firstArray, secondArray);
        Console.WriteLine("Subtracting polynomials: ");
        List<int> secondPolynom = SubtractPolynomials(firstArray, secondArray);
        Console.WriteLine("Multiplying polynomials: ");
        int[] thirdPolynom = MultiplyPolynoms(firstArray, secondArray);

    }
}