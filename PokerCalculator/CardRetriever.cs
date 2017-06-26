namespace PokerCalculator
{
    public class CardRetriever : ICardRetriever
    {
        public Card RetrieveCard(string rankAndSuitConcatenation)
        {
            return DeckDictionary.Cards[rankAndSuitConcatenation];
        }
    }
}