using System;

class IsItLeapYear
{
    static void IsItLeap(DateTime year)
    {
        if (DateTime.IsLeapYear(year.Year) == true)
        {
            Console.WriteLine("{0} is a leap year", year.Year);
        }
        else
        {
            Console.WriteLine("{0} is not a leap year", year.Year);
        }
    }

    static void Main()
    {
        DateTime checkYear = new DateTime(2012, 1, 22);
        IsItLeap(checkYear);
    }
}
