using System.Collections.Generic;

namespace PokerCalculator
{
    public interface ICacher
    {
        List<Card> Deck { get; set; }

        void CacheDeck();

        void RemoveCard(Card cardToRemove);

        void Dispose();
    }
}