namespace PokerCalculator
{
    public class CardConstructor : ICardConstructor
    {
        public Card ConstructCard(string rankAndSuitConcatenation)
        {
            return Deck.Cards[rankAndSuitConcatenation];
        }
    }
}