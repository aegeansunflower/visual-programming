using System;

class DeckOfCards
{
    private static Random randomNumbers = new Random();
    private const int NumberOfCards = 52;
    private Card[] deck = new Card[NumberOfCards];
    private int currentCard = 0;

    public DeckOfCards()
    {
        string[] faces = {"As", "İki", "Üç", "Dört", "Beş", "Altı",
                          "Yedi", "Sekiz", "Dokuz", "On", "Joker" "Kraliçe", "Kral"};
        string[] suits = { "Kalp", "Elmas", "Sinek", "Dama" };

        // Desteyi oluştur
        for (var count = 0; count < deck.Length; ++count)
        {
            deck[count] = new Card(faces[count % 13], suits[count / 13]);
        }
    }

    public void Shuffle()
    {
        currentCard = 0;
        for (var first = 0; first < deck.Length; ++first)
        {
            var second = randomNumbers.Next(NumberOfCards);
            Card temp = deck[first];
            deck[first] = deck[second];
            deck[second] = temp;
        }
    }

    public Card DealCard()
    {
        if (currentCard < deck.Length)
            return deck[currentCard++];
        else
            return null;
    }
}
