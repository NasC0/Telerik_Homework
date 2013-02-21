using System;
using System.Text;

class printingASCIITable
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;
        for (byte counter = 0; counter < 255; counter++)
        {
            Console.WriteLine((char)counter);
        }
    }
}
 