using System;
using System.Globalization;
using System.Threading;

class AddHoursAndMinutesToDate
{
    static void Main()
    {
        string dateFormat = "dd.MM.yyyy HH:mm:ss";
        Console.WriteLine("Enter your date and time: ");
        string dateAndTimeString = Console.ReadLine();
        DateTime dateAndTime;
        DateTime.TryParseExact(dateAndTimeString, dateFormat, CultureInfo.GetCultureInfo("bg-BG"), DateTimeStyles.None, out dateAndTime);
        dateAndTime.AddHours(6.5);
        Console.WriteLine("Date and time is: {0}.", dateAndTime);
        Console.WriteLine("Day of the week is: {0}.", dateAndTime.DayOfWeek);
    }
}
