using System;

class Program
{
    static int Workdays(DateTime date)
    {
        DateTime now = DateTime.Today;
        int days = date.DayOfYear - now.DayOfYear;
        if (date.Year > now.Year)
        {
            DateTime nowTemp = now;
            for (int i = 0; i < date.Year - now.Year; i++)
            {
                nowTemp = nowTemp.AddYears(1);
                if (DateTime.IsLeapYear(nowTemp.Year))
                {
                    days += 366;
                }
                else
                {
                    days += 365;
                }
            }
        }
        DateTime[] offDays = new DateTime[]
        {
           new DateTime(2013, 1, 1),
           new DateTime(2013, 3, 1),
           new DateTime(2013, 5, 1),
           new DateTime(2013, 5, 2),
           new DateTime(2013, 5, 3),
           new DateTime(2013, 5, 4),
           new DateTime(2013, 5, 5),
           new DateTime(2013, 5, 6),
           new DateTime(2013, 5, 24),
           new DateTime(2013, 9, 6),
           new DateTime(2013, 9, 22),
           new DateTime(2013, 12, 24),
           new DateTime(2013, 12, 25),
           new DateTime(2013, 12, 26),
           new DateTime(2013, 12, 31),
        };

        int countOffDays = 0;
        for (int i = 0; i < days; i++)
        {
            for (int j = 0; j < offDays.Length; j++)
            {
                if (now == offDays[j] && (int)now.DayOfWeek != 6 && (int)now.DayOfWeek != 0)
                {
                    countOffDays++;
                }
            }

            if ((int)now.DayOfWeek == 6 || (int)now.DayOfWeek == 0)
            {
                countOffDays++;
            }
            now = now.AddDays(1);
        }
        return days - countOffDays;
    }

    static void Main()
    {
        Console.Write("Enter the later date (YYYY MM DD): ");
        DateTime later = DateTime.Parse(Console.ReadLine());
        int workdays = Workdays(later);
        Console.WriteLine("The number of workdays between {0} and {1} is: {2}", DateTime.Today, later, workdays);
    }
}
