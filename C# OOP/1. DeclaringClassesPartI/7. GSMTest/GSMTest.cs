using System;
using GSMType.Common;

class GSMTest
{
    static void Main()
    {
        GSM[] gsmArray = new GSM[4];
        for (int i = 0; i < 4; i++)
        {
            gsmArray[i] = new GSM("Model", "Manufacturer", 203.99m, "", new Battery(), new Display());
        }
        for (int i = 0; i < gsmArray.Length; i++)
        {
            Console.WriteLine(gsmArray[i].ToString());
        }
        Console.WriteLine(GSM.IPhone);
    }
}
