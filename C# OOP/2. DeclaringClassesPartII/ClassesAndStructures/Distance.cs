using System;

namespace Points
{
    static public class Distance
    {
        static public int Calculate(Point one, Point two)
        {
            int result = (int)Math.Sqrt(Math.Pow((one.XCoord - two.XCoord), 2) + Math.Pow((one.YCoord - two.YCoord), 2) + Math.Pow((one.ZCoord - two.ZCoord), 2));
            return result;
        }
    }
}
