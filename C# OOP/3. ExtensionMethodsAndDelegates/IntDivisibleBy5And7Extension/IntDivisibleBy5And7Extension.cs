using System;

namespace IntExtensions
{
    public static class IntDivisibleBy5And7Extension
    {
        public static bool DivisibleBy5And7(this int number)
        {
            bool divisable;
            if (number % 5 == 0 && number % 7 == 0)
            {
                divisable = true;
            }
            else
            {
                divisable = false;
            }
            return divisable;
        }
    }
}
