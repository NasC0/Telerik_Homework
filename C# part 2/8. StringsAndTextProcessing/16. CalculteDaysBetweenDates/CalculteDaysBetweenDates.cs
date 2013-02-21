using System;
using System.Globalization;

class CalculteDaysBetweenDates
{
    static void Main()
    {
        try
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.Write("Enter the first date: ");
            string firstDateString = Console.ReadLine();
            string[] dateFormat = { "dd.MM.yyyy", "d.MM.yyyy", "d.M.yyyy", "dd.M.yyyy" };
            DateTime firstDate = DateTime.ParseExact(firstDateString, dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None);
            Console.Write("Enter the second date: ");
            string secondDateString = Console.ReadLine();
            DateTime secondDate = DateTime.ParseExact(secondDateString, dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None);
            if (firstDate > secondDate)
            {
                throw new ApplicationException();
            }
            int days = 0;
            if (secondDate.Year > firstDate.Year)
            {
                days += 365;
                days += secondDate.DayOfYear - firstDate.DayOfYear;
            }
            else
            {
                days = secondDate.DayOfYear - firstDate.DayOfYear;
            }
            Console.WriteLine("The distance between {0} and {1} is {2} days.", firstDateString, secondDateString, days);
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter the date in the format dd.MM.yyyy!");
        }
        catch (ApplicationException)
        {
            Console.WriteLine("The second date must not precede the first date!");
        }
    }
}