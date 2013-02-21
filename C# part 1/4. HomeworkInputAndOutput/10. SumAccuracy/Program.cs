using System;
class Program
{
    static void Main()
    {
        double sum = 1;
        double divisor = 2;
        double temp = 1;
        while (temp > 0.001)
        {
            temp = 1 / divisor;
            if (divisor % 2 == 0)
            {
                sum += temp;
            }
            else
            {
                sum -= temp;
            }
            divisor++;
        }
        Console.WriteLine("{0 : 0.000}", sum);
    }
}
