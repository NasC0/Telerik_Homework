using System;
using System.Diagnostics;
using TimerClass;

class TimerTest
{
    static void Main()
    {
        Timer.TimerDelegate del = Timer.ExecuteMethod; // initialising the delegate
        del(3);    // setting the interval of execution
    }
}
