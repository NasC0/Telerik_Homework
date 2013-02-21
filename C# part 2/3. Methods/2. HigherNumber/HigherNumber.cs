using System;

class HigherNumber
{
    static int GetMax(int one, int two)
    {
        if (one > two)
        {
            Console.WriteLine("The first number is bigger than the second one");
            return one;
        }
        else if(one == two)
        {
            Console.WriteLine("The numbers are equal");
            return one;
        }
        else
        {
            Console.WriteLine("The second number is bigger than the first one");
            return two;
        }
    }

    static void Main()
    {
        GetMax(2, 1);
    }
}