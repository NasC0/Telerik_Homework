using System;
class Program
{
    static void Main()
    {
        string[] paints = new string[4];
        paints[0] = "Diamonds";
        paints[1] = "Spades";
        paints[2] = "Hearts";
        paints[3] = "Clubs";

        string[] cards = new string[13];
        cards[0] = "Two";
        cards[1] = "Three";
        cards[2] = "Four";
        cards[3] = "Five";
        cards[4] = "Six";
        cards[5] = "Seven";
        cards[6] = "Eight";
        cards[7] = "Nine";
        cards[8] = "Ten";
        cards[9] = "Jack";
        cards[10] = "Queen";
        cards[11] = "King";
        cards[12] = "Ace";

        for (int i = 0; i < paints.Length; i++)
        {
            Console.WriteLine("- - - - - - - - {0} - - - - - - - -", paints[i]);
            for (int k = 0; k < cards.Length; k++)
            {
                Console.WriteLine("{0} of {1}", cards[k], paints[i]);
            }
        }
    }
}
