/* Using delegates write a class Timer that 
 * has can execute certain method at each t seconds. */

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
