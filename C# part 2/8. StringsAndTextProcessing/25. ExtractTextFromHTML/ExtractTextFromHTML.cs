using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

class ExtractTextFromHTML
{
    static string ExtractTitle(string html)
    {
        if (html.Contains("<title>"))
        {
            int startIndex = html.IndexOf("<title>") + 7;
            int lengt = html.IndexOf("</title>") - startIndex;
            string title = html.Substring(startIndex, lengt);
            return title;
        }
        return string.Empty;
    }

    static void ExtractHTML(string html)
    {
        string duplicate = html.Remove(0, html.IndexOf("<body>") + "<body".Length + 1);
        MatchCollection matches = Regex.Matches(duplicate, @">(.*?)<");
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }

    static void Main()
    {
        string html = @"<html><head><title>News</title></head><body><p><a href=""http://academy.telerik.com"">TelerikAcademy</a>aims to provide free real-world practicaltraining for young people who want to turn into skillful .NET software engineers.</p></body> </html>";
        string title = ExtractTitle(html);
        ExtractHTML(html);
    }
}
