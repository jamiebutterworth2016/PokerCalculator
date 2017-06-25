namespace PokerCalculator
{
    public interface ICardConstructor
    {
        Card ConstructCard(string rankAndSuitConcatenation);
    }
}