using System;

class ApplyConstructors
{
    static void Main()
    {
        Battery battery = new Battery("teehee");
        Display display = new Display(5.5);
        GSM bla = new GSM("zte", "manufacturer", 259.99m, "ME", battery, display);
    }
}