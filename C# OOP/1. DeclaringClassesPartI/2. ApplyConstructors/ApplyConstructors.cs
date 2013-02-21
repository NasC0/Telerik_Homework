using System;
using GSMType.Common;

class ApplyConstructors
{
    static void Main()
    {
        Battery battery = new Battery("teehee");
        Display display = new Display(5.5);
        GSM gsm = new GSM("zte", "manufacturer", 259.99m, "ME", battery, display);
    }
}