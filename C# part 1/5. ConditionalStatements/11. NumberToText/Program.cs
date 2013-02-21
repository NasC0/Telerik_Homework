using System;
class Program
{
    static void Main()
    {
        string[] ones = new string[10];
        {
            ones[0] = "Zero";
            ones[1] = "One";
            ones[2] = "Two";
            ones[3] = "Three";
            ones[4] = "Four";
            ones[5] = "Five";
            ones[6] = "Six";
            ones[7] = "Seven";
            ones[8] = "Eight";
            ones[9] = "Nine";
        }
        string[] specials = new string[10];
        {
            specials[0] = "Ten";
            specials[1] = "Eleven";
            specials[2] = "Twelve";
            specials[3] = "Thirteen";
            specials[4] = "Fourteen";
            specials[5] = "Fifteen";
            specials[6] = "Sixteen";
            specials[7] = "Seventeen";
            specials[8] = "Eighteen";
            specials[9] = "Nineteen";
        }
        string[] tens = new string[8];
        {
            tens[0] = "Twenty";
            tens[1] = "Thirty";
            tens[2] = "Fourty";
            tens[3] = "Fifty";
            tens[4] = "Sixty";
            tens[5] = "Seventy";
            tens[6] = "Eighty";
            tens[7] = "Ninety";
        }
        string[] hundreds = new string[9];
        {
            hundreds[0] = "One hundred";
            hundreds[1] = "Two hundred";
            hundreds[2] = "Three hundred";
            hundreds[3] = "Four hundred";
            hundreds[4] = "Five hundred";
            hundreds[5] = "Six hundred";
            hundreds[6] = "Seven hundred";
            hundreds[7] = "Eight hundred";
            hundreds[8] = "Nine hundred";
        }
        Console.Write("Enter your number [0...999]: ");
        int number = Int32.Parse(Console.ReadLine());
        if (number >= 0 && number <= 9)
        {
            Console.WriteLine("{0}", ones[number]);
        }
        else if (number >= 10 && number <= 19)
        {
            int specialNumbers = number % 10;
            Console.WriteLine("{0}", specials[specialNumbers]);
        }
        else if (number >= 20 && number < 100)
        {
            int tenths = number / 10;
            int tenthsPartTwo = number % 10;
            if (tenthsPartTwo == 0)
            {
                Console.WriteLine("{0}", tens[tenths - 2]);
            }
            else
            {
                Console.WriteLine("{0} {1}", tens[tenths - 2], ones[tenthsPartTwo]);
            }
        }
        else if (number >= 100 && number < 1000)
        {
            int numberHundreds = number / 100;
            int numberTensHolder = number / 10;
            int numberTens = numberTensHolder % 10;
            int numberDigits = number % 10;
            if (numberTens == 0)
            {
                Console.WriteLine("{0} and {1}", hundreds[numberHundreds - 1], ones[numberDigits]);
            }
            else if (numberTens == 1)
            {
                Console.WriteLine("{0} and {1}", hundreds[numberHundreds - 1], specials[numberDigits]);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", hundreds[numberHundreds - 1], tens[numberTens - 2], ones[numberDigits]);   
            }
        }
        else
        {
            Console.WriteLine("Please enter a valid number");
        }
    }
}