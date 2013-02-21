using System;

class FormatNumber
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        string[] outputs = { number.ToString("E"), number.ToString("P"), number.ToString("X"), number.ToString() };
        for (int i = 0; i < outputs.Length; i++)
        {
            outputs[i] = outputs[i].PadLeft(15);
            Console.WriteLine(outputs[i]);
        }
    }
}
