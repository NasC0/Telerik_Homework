using System;
using GSMType.Common;

class IphoneInstance
{
    static void Main()
    {
        GSM gsm = GSM.IPhone;
        Console.WriteLine("Model: {0}, Manufacturer: {1}, Price: {2}", gsm.Model, gsm.Manufacturer, gsm.Price);
        Console.WriteLine("-------------------------");
        Console.WriteLine("Static field");
        Console.WriteLine("Model: {0}, Manufacturer: {1}, Price: {2}", GSM.IPhone.Model, GSM.IPhone.Manufacturer, GSM.IPhone.Price);
    }
}
