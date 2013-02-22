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
        List<Call> history = gsm.CallHistory;
        int maxDuration = history[0].Duration;
        int position = 0;
        for (int i = 1; i < history.Count; i++)
        {
            if (history[i].Duration > maxDuration)
            {
                maxDuration = history[i].Duration;
                position = i;
            }
        }
        gsm.RemoveCall(history[position].PhoneNumber);
        Console.WriteLine(gsm.CallsPrice(0.37m));
        gsm.ClearHistory();
        gsm.PrintCalls();
    }
}
