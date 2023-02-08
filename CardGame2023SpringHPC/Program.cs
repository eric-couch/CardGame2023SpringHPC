using CardGame2023SpringHPC;

List<Card> Deck = new List<Card>();

for (int rank = 2; rank <= 14; rank++) {
    for (int suit=0; suit <4; suit++)
    {
        string convertedRank = String.Empty;
        string convertedSuit = String.Empty;
        switch (rank)
        {
            case 11:
                convertedRank = "J";
                break;
            case 12:
                convertedRank = "Q";
                break;
            case 13:
                convertedRank = "K";
                break;
            case 14:
                convertedRank = "A";
                break;
            default:
                convertedRank = rank.ToString();
                break;
        }
        switch (suit)
        {
            case 0:
                convertedSuit = "♥";
                break;
            case 1:
                convertedSuit = "♦";
                break;
            case 2:
                convertedSuit = "♣";
                break;
            case 3:
                convertedSuit = "♠";
                break;
        }
        Card currentCard = new Card(convertedSuit, convertedRank, rank);
        Deck.Add(currentCard);
    }
}
Console.WriteLine("Here are your cards:");
for (int cardNum = 0; cardNum < 5; cardNum++)
{
    Card thisCard = DealCard(Deck);
    Console.Write($"{thisCard}\t");
}
Console.WriteLine();
Console.WriteLine($"How many cards are left in our deck: {Deck.Count}");
static Card DealCard(List<Card> cards)
{
    Random rnd = new Random();
    int cardToSelect = rnd.Next(cards.Count);
    Card dealtCard = cards[cardToSelect];
    cards.RemoveAt(cardToSelect);
    return dealtCard;        
}

