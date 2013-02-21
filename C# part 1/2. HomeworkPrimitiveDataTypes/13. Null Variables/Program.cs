using System;
class nullVariables
{
    static void Main()
    {
        int? firstInt; // declaring a null integer
        double? firstDouble; // declaring a null double
        // initialising them to some number
        firstInt = 5;
        firstDouble = 5.2;
        // Console test
        Console.WriteLine(firstInt);
        Console.WriteLine(firstDouble);
        // initialising the two variables to null
        firstInt = null;
        firstDouble = null;
        // console test
        Console.WriteLine(firstInt);
        Console.WriteLine(firstDouble);
    }
}