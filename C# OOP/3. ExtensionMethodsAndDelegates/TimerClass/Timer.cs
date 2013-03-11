using System;
using System.Diagnostics;

namespace TimerClass
{
    public static class Timer
    {
        public  delegate void TimerDelegate(double seconds);

        private static Stopwatch sw = new Stopwatch();

        public static void ExecuteMethod(double seconds)
        {
            sw.Start();
            while (true)
            {
                if (sw.ElapsedMilliseconds >= seconds * 1000)
                {
                    Console.WriteLine("This method is executed every {0} seconds", seconds);
                    sw.Restart();
                }
            }
        }
    }
}
