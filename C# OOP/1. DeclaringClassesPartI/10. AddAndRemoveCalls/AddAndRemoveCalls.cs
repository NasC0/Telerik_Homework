using System;
using GSMType.Common;
using System.Globalization;

class AddAndRemoveCalls
{
    static void Main()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        GSM gsm = new GSM("Galaxy S3", "Samsung");
        gsm.AddCall(846022, 150);
        gsm.AddCall(35956, 132);
        gsm.PrintCalls();
        Console.WriteLine("-------------");
        gsm.RemoveCall(35956);
        gsm.PrintCalls();
        Console.WriteLine("-------------");
        gsm.AddCall(654213, 32);
        gsm.ClearHistory();
        gsm.PrintCalls();
    }
}
