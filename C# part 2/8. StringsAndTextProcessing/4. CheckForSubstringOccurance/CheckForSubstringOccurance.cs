using System;
using System.Diagnostics;

class CheckForSubstringOccurance
{
    static void Main()
    {
        string check = "We are living in an yellow submarine. We don't have anyhing else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days";
        check = check.ToLower();
        Console.Write("Enter the word you want to check for: ");
        string checkFor = Console.ReadLine();
        int count = 0;
        while (check.IndexOf(checkFor, 0) != -1)
        {
            check = check.Remove(check.IndexOf(checkFor), 2);
            count++;
        }
        Console.WriteLine("Number of \"{0}\" in the string is: {1}", checkFor, count);
    }
}
