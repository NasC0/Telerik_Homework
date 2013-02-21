using System;
class stringTypeCasting
{
    static void Main()
    {
        string hello = "Hello"; //declaring the 'hello' string
        string world = "World!"; //declaring the 'world' string
        object helloWorld = hello + " " + world; //concatenating the two strings
        //test, should return "Hello World!"
        Console.WriteLine(helloWorld);
        string helloWorldToString = helloWorld.ToString(); // casting the helloWorld object to string
        //test of the helloWorld string, should return "Hello World!"
        Console.WriteLine(helloWorldToString);
    }
}