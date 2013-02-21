using System;
using System.Globalization;
class floatCompare
{
    static void Main()
    {
        Console.WriteLine("Enter two floating-point numbers to be compared: "); //Prompting the user to input two floating-point variables
        string numberOne = Console.ReadLine(); //Reading the first variable
        string numberTwo = Console.ReadLine(); //Reading the second variable
        decimal numberOneToDecimal = Decimal.Parse(numberOne, CultureInfo.GetCultureInfo("en-US"));  //Parsing the first variable to Decimal
        decimal numberTwoToDecimal = Decimal.Parse(numberTwo, CultureInfo.GetCultureInfo("en-US"));  //Parsing the second variable to Decimal
        if (numberOneToDecimal > numberTwoToDecimal) //Comparing the two variables
            Console.WriteLine(numberOneToDecimal + " is greater than" + numberTwoToDecimal);
        if (numberOneToDecimal == numberTwoToDecimal)
            Console.WriteLine(numberOneToDecimal + " is equal to " + numberTwoToDecimal);
        else
            Console.WriteLine(numberTwoToDecimal + " is greater than " + numberOneToDecimal);
    }
}
