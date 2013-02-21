using System;
using GSMType.Common;

class BatteryEnumeration
{
    static void Main(string[] args)
    {
        Battery battery = new Battery("hue", 5.4, 3.2, BatteryType.NiMH);
    }
}
