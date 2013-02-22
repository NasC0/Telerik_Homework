using System;
using GSMType.Common;
using System.Collections.Generic;

class CallHistory
{
    static void Main()
    {
        GSM gsm = new GSM("Galaxy S3", "Samsung");
        List<Call> callList = gsm.CallHistory;
        foreach (Call calls in callList)
        {
            Console.WriteLine(calls);
        }
    }
}
