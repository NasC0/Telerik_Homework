using System;
class quotationAndEscaping
{
    static void Main()
    {
        string quotatedString = @"The ""use"" of quotations causes difficulties."; // quotated string
        string escapedString = "The \"use\" of quotations causes difficulties."; // escaped string
        //test, should print out "The "use" of quotations causes difficulties." twice\
        Console.WriteLine(quotatedString);
        Console.WriteLine(escapedString);
    }
}