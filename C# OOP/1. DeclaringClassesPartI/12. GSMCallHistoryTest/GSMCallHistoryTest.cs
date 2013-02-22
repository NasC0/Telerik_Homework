using System;
using GSMType.Common;
using System.Collections.Generic;

class GSMCallHistoryTest
{
    static void Main()
    {
        GSM gsm = GSM.IPhone;
        gsm.AddCall(3596321, 123);
        gsm.AddCall(3641789, 101);
        gsm.AddCall(36417863, 147);
        gsm.PrintCalls();
        Console.WriteLine(gsm.CallsPrice(0.37m));
        Console.WriteLine();
        gsm.RemoveLongestcall();
        gsm.PrintCalls();
        Console.WriteLine(gsm.CallsPrice(0.37m));
        gsm.ClearHistory();
        gsm.PrintCalls();
    }
}
