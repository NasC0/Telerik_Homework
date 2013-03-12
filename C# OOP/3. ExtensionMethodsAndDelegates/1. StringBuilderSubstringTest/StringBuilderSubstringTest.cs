/* Implement an extension method Substring(int index, int length) 
 * for the class StringBuilder that returns new StringBuilder 
 * and has the same functionality as Substring in the class String. */

using System;
using System.Text;
using StringBuilderExtend;

class StringBuilderSubstringTest
{
    static void Main()
    {
        StringBuilder test = new StringBuilder();
        test.Append("This is a test");
        test = test.Substring(0, test.Length - 3);
        Console.WriteLine(test);
    }
}
