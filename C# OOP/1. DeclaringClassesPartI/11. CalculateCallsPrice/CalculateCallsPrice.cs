using System;
using System.Globalization;
using GSMType.Common;

class CalculateCallsPrice
{
    static void Main()
    {
        GSM gsm = new GSM("Galaxy S3", "Samsung");
        gsm.AddCall(846022, 150);
        gsm.AddCall(35956, 132);
        Console.WriteLine(gsm.CallsPrice(0.37m));
    }
}
