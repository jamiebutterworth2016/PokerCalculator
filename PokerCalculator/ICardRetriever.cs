namespace PokerCalculator
{
    public interface ICardRetriever
    {
        Card RetrieveCard(string rankAndSuitConcatenation);
    }
}