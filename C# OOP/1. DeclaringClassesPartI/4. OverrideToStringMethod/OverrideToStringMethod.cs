using GSMType.Common;
using System;


class OverrideToStringMethod
{
    static void Main()
    {
        GSM gsm = new GSM("Galaxy S3", "Samsung", 899.99m, "30 milion people");
        string gsmString = gsm.ToString();
        Console.WriteLine(gsm);
    }
}
