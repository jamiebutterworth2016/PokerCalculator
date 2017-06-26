using System.Runtime.Caching;
using System.Collections.Generic;
using System.Linq;

namespace PokerCalculator
{
    public class Cacher : ICacher
    {
        public List<Card> Deck { get; set; }

        public void CacheDeck()
        {
            var deck = new Deck();

            var cards = deck.Cards;

            var cache = MemoryCache.Default;

            var cacheItemPolicy = new CacheItemPolicy();

            cache.Set("deck", cards, cacheItemPolicy);

            Deck = (List<Card>)cache.Get("deck");
        }

        public void RemoveCard(Card cardToRemove)
        {
            var card = Deck.Where(x => x.Rank == cardToRemove.Rank && x.Suit == cardToRemove.Suit).Single();

            Deck.Remove(card);
        }

        public void Dispose()
        {
            var cache = MemoryCache.Default;

            cache.Dispose();
        }
    }
}