using System;

class TaskSolver
{
    static void Reverse(int number)
    {
        if (number < 0)
        {
            Console.WriteLine("The number must be non-negative!");
        }
        else
        {
            string numberString = number.ToString();
            Console.Write("Your reversed number is: ");
            for (int i = numberString.Length - 1; i >= 0; i--)
            {
                Console.Write(numberString[i]);
            }
            Console.WriteLine();
        }

    }

    static int[] ArrayCreator()
    {
        Console.WriteLine("Enter the size of your array: ");
        int size = int.Parse(Console.ReadLine());
        if (size < 1)
        {
            Console.WriteLine("The sequence must not be empty");
            return ArrayCreator();
        }
        int[] array = new int[size];
        Console.WriteLine("Populate your array: ");
        for (int i = 0; i < size; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        return array;
    }

    static int Average(int[] array)
    {
        if (array.Length == 0)
        {
            Console.WriteLine("The sequence must not be empty!");
            Console.WriteLine("Returned average = 0. Restart the program to start over.");
            return 0;
        }
        else
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            sum = sum / array.Length;
            return sum;
        }

    }

    static void LinearEquations(int a, int b)
    {
        if (a == 0)
        {
            Console.WriteLine("A should not be equal to 0");
        }
        else
        {
            Console.WriteLine("X = {0}", -b / a);
        }
    }

    static void Main()
    {
        Console.WriteLine("What task do you want me to begin? ");
        Console.WriteLine("1. Reverse a number's digits.");
        Console.WriteLine("2. Calculate the average of a sequence of integers.");
        Console.WriteLine("3. Solve a linear equation.");
        Console.WriteLine();
        int choice = int.Parse(Console.ReadLine());
        if (choice < 1 || choice > 3)
        {
            Console.WriteLine("Please make a valid choice (1 - 3)");
            Console.WriteLine();
            Main();
        }
        else if (choice == 1)
        {
            Console.WriteLine();
            Console.WriteLine("You have selected 1. Reverse a number's digits");
            Console.Write("Please enter the number you want reversed: ");
            int number = int.Parse(Console.ReadLine());
            Reverse(number);
        }
        else if (choice == 2)
        {
            Console.WriteLine();
            Console.WriteLine("You have selected 2. Calculate the average of a sequence of integers.");
            int[] array = ArrayCreator();
            int average = Average(array);
            Console.WriteLine("The average of your sequence is: {0}", average);
        }
        else if (choice == 3)
        {
            Console.WriteLine();
            Console.WriteLine("You have selected 3. Solve a linear equation.");
            Console.Write("Enter coefficient A: ");
            int numA = int.Parse(Console.ReadLine());
            Console.Write("Enter coefficient B: ");
            int numB = int.Parse(Console.ReadLine());
            LinearEquations(numA, numB);
        }
    }
}
