using System;
class ReadNumber
{
    static void Main()
    {
        try
        {
            Console.Write("Enter your number: ");
            int number = int.Parse(Console.ReadLine());
            if (number < 0)
            {
                throw new ArgumentException("Invalid number!");
            }
            int numberSquared = (int)Math.Sqrt(number);
            Console.WriteLine(numberSquared);
        }
        catch (ArgumentException argEx)
        {
            Console.WriteLine(argEx.Message);
        }
        catch (OverflowException oe)
        {
            Console.WriteLine(oe.Message);
        }
        catch (FormatException fe)
        {
            Console.WriteLine(fe.Message);
        }
        finally
        {
            Console.WriteLine("Good-bye.");
        }
    }
}
