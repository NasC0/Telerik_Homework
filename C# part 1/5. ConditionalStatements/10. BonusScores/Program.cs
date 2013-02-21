using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the score you want modified: ");
        int score = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Bonus score multiplier range: 1 - 3, multiplies the score by 10");
        Console.WriteLine("4-6, multilies the score by 100");
        Console.WriteLine("7 - 9, multiplies the score by 1000: ");
        int multiplier = Int32.Parse(Console.ReadLine());
        switch (multiplier)
        {
            case 1:
                score *= 10;
                Console.WriteLine("The new score is: {0}", score);
                break;
            case 2:
                score *= 10;
                Console.WriteLine("The new score is: {0}", score);
                break;
            case 3:
                score *= 10;
                Console.WriteLine("The new score is: {0}", score);
                break;
            case 4:
                score *= 100;
                Console.WriteLine("The new score is: {0}", score);
                break;
            case 5:
                score *= 100;
                Console.WriteLine("The new score is: {0}", score);
                break;
            case 6:
                score *= 100;
                Console.WriteLine("The new score is: {0}", score);
                break;
            case 7:
                score *= 1000;
                Console.WriteLine("The new score is: {0}", score);
                break;
            case 8:
                score *= 1000;
                Console.WriteLine("The new score is: {0}", score);
                break;
            case 9:
                score *= 1000;
                Console.WriteLine("The new score is: {0}", score);
                break;
            default:
                Console.WriteLine("Error, the input number must be in the range 0 < n < 10!");
                break;
        }
    }
}
