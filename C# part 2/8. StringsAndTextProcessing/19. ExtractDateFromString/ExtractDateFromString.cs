using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Threading;

class ExtractDateFromString
{
    static void Main()
    {
        string str = "12.05.2012 date";
        string pattern = @"(0[1-9]|[12][0-9]|3[01])\.(0[1-9]|1[012])\.(19|20)\d\d";
        DateTime date;
        MatchCollection matches = Regex.Matches(str, pattern);
        foreach (Match match in matches)
        {
            if (DateTime.TryParseExact(match.Value, "dd.mm.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
            {
                Console.WriteLine(date.ToString(CultureInfo.GetCultureInfo("en-CA")));
            }
        }
    }
}
