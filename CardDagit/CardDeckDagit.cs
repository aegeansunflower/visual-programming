using System;

class DeckOfCardsTest
{
    static void Main()
    {
        var myDeck = new DeckOfCards();
        myDeck.Shuffle(); 
        for (var i = 0; i < 52; ++i)
        {
            Console.Write($"{myDeck.DealCard(),-19}");
            if ((i + 1) % 4 == 0) Console.WriteLine();
        }
    }
}
