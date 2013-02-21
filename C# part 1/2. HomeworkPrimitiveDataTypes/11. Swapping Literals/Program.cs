using System;
class swappingLiterals
{
    static void Main()
    {
        int firstVariable = 5; // declaring the two variables
        int secondVariable = 10;
        // test
        Console.WriteLine("First variable: " + firstVariable);
        Console.WriteLine("Second variable: " + secondVariable);
        int swapVariable = secondVariable; // declaring the swap variable and initialising it to the second variable
        secondVariable = firstVariable; // initialising the second variable to the first variable
        firstVariable = swapVariable; // initialising the swap variable to the first variable
        // second test, should print out the swapped variables
        Console.WriteLine("First variable: " + firstVariable);
        Console.WriteLine("Second variable: " + secondVariable);
    }
}
