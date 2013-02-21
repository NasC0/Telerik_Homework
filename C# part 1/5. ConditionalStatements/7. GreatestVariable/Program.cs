using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter five variables: ");
        double firstVar = double.Parse(Console.ReadLine());
        double secondVar =double.Parse(Console.ReadLine());
        double thirdVar = double.Parse(Console.ReadLine());
        double fourthVar = double.Parse(Console.ReadLine());
        double fifthVar = double.Parse(Console.ReadLine());
        if (firstVar > secondVar && firstVar > thirdVar && firstVar > fourthVar && firstVar > fifthVar)
        {
            Console.WriteLine("The greatest variable is: {0}", firstVar);
        }
        else if (secondVar > firstVar && secondVar > thirdVar && secondVar > fourthVar && secondVar > fifthVar)
        {
            Console.WriteLine("The greatest variable is: {0}", secondVar);
        }
        else if (thirdVar > firstVar && thirdVar > secondVar && thirdVar > fourthVar && thirdVar > fifthVar)
        {
            Console.WriteLine("The greatest variable is: {0}", thirdVar);
        }
        else if (fourthVar > firstVar && fourthVar > secondVar && fourthVar > thirdVar && fourthVar > fifthVar)
        {
            Console.WriteLine("The greatest variable is: {0}", fourthVar);
        }
        else
        {
            Console.WriteLine("The greatest variable is: {0}", fifthVar);
        }
    }
}