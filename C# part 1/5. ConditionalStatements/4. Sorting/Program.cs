using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter three numbers: ");
        int firstNumber = Int32.Parse(Console.ReadLine());
        int secondNumber = Int32.Parse(Console.ReadLine());
        int thirdNumber = Int32.Parse(Console.ReadLine());
        if (firstNumber == secondNumber && firstNumber == thirdNumber && secondNumber == thirdNumber)
        {
            Console.WriteLine("The numbers are equal.");
        }
        else if (thirdNumber < secondNumber && thirdNumber < firstNumber)
        {
            if (secondNumber < firstNumber)
            {
                int temp = thirdNumber;
                thirdNumber = firstNumber;
                firstNumber = temp;
                Console.WriteLine("{0}, {1}, {2}", firstNumber, secondNumber, thirdNumber);
            }
            else
            {
                int tempOne = thirdNumber;
                thirdNumber = firstNumber;
                firstNumber = tempOne;
                if (secondNumber > thirdNumber)
                {
                    int tempTwo = secondNumber;
                    secondNumber = thirdNumber;
                    thirdNumber = tempTwo;
                    Console.WriteLine("{0}, {1}, {2}", firstNumber, secondNumber, thirdNumber);
                }
            }
        }
        else if (secondNumber < firstNumber && secondNumber < thirdNumber)
        {
            if (thirdNumber < firstNumber)
            {
                int temp = secondNumber;
                secondNumber = firstNumber;
                firstNumber = temp;
                temp = thirdNumber;
                thirdNumber = secondNumber;
                secondNumber = temp;
                Console.WriteLine("{0}, {1}, {2}", firstNumber, secondNumber, thirdNumber);
            }
            else
            {
                int temp = secondNumber;
                secondNumber = firstNumber;
                firstNumber = temp;
                if (thirdNumber > firstNumber)
                {
                    int tempTwo = thirdNumber;
                    thirdNumber = secondNumber;
                    thirdNumber = tempTwo;
                    Console.WriteLine("{0}, {1}, {2}", firstNumber, secondNumber, thirdNumber);
                }
            }
        }
        else if (firstNumber < secondNumber && firstNumber < thirdNumber)
        {
            if (secondNumber < thirdNumber)
            {
                Console.WriteLine("{0}, {1}, {2}", firstNumber, secondNumber, thirdNumber);   
            }
            else
            {
                int temp = thirdNumber;
                thirdNumber = secondNumber;
                secondNumber = temp;
                Console.WriteLine("{0}, {1}, {2}", firstNumber, secondNumber, thirdNumber);   
            }
        }
    }
}
