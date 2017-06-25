using System.Collections.Generic;

namespace PokerCalculator
{
    public static class Deck
    {
        public static IDictionary<string, Card> Cards {
            get
            {
                return new Dictionary<string, Card>()
                {
                    { "ac", new Card() { Rank = "Ace", Suit = "Club" } },
                    { "kc", new Card() { Rank = "King", Suit = "Club" } },
                    { "qc", new Card() { Rank = "Queen", Suit = "Club" } },
                    { "jc", new Card() { Rank = "Jack", Suit = "Club" } },
                    { "tc", new Card() { Rank = "Ten", Suit = "Club" } },
                    { "9c", new Card() { Rank = "Nine", Suit = "Club" } },
                    { "8c", new Card() { Rank = "Eight", Suit = "Club" } },
                    { "7c", new Card() { Rank = "Seven", Suit = "Club" } },
                    { "6c", new Card() { Rank = "Six", Suit = "Club" } },
                    { "5c", new Card() { Rank = "Five", Suit = "Club" } },
                    { "4c", new Card() { Rank = "Four", Suit = "Club" } },
                    { "3c", new Card() { Rank = "Three", Suit = "Club" } },
                    { "2c", new Card() { Rank = "Two", Suit = "Club" } },
                    { "ad", new Card() { Rank = "Ace", Suit = "Diamond" } },
                    { "kd", new Card() { Rank = "King", Suit = "Diamond" } },
                    { "qd", new Card() { Rank = "Queen", Suit = "Diamond" } },
                    { "jd", new Card() { Rank = "Jack", Suit = "Diamond" } },
                    { "td", new Card() { Rank = "Ten", Suit = "Diamond" } },
                    { "9d", new Card() { Rank = "Nine", Suit = "Diamond" } },
                    { "8d", new Card() { Rank = "Eight", Suit = "Diamond" } },
                    { "7d", new Card() { Rank = "Seven", Suit = "Diamond" } },
                    { "6d", new Card() { Rank = "Six", Suit = "Diamond" } },
                    { "5d", new Card() { Rank = "Five", Suit = "Diamond" } },
                    { "4d", new Card() { Rank = "Four", Suit = "Diamond" } },
                    { "3d", new Card() { Rank = "Three", Suit = "Diamond" } },
                    { "2d", new Card() { Rank = "Two", Suit = "Diamond" } },
                    { "ah", new Card() { Rank = "Ace", Suit = "Heart" } },
                    { "kh", new Card() { Rank = "King", Suit = "Heart" } },
                    { "qh", new Card() { Rank = "Queen", Suit = "Heart" } },
                    { "jh", new Card() { Rank = "Jack", Suit = "Heart" } },
                    { "th", new Card() { Rank = "Ten", Suit = "Heart" } },
                    { "9h", new Card() { Rank = "Nine", Suit = "Heart" } },
                    { "8h", new Card() { Rank = "Eight", Suit = "Heart" } },
                    { "7h", new Card() { Rank = "Seven", Suit = "Heart" } },
                    { "6h", new Card() { Rank = "Six", Suit = "Heart" } },
                    { "5h", new Card() { Rank = "Five", Suit = "Heart" } },
                    { "4h", new Card() { Rank = "Four", Suit = "Heart" } },
                    { "3h", new Card() { Rank = "Three", Suit = "Heart" } },
                    { "2h", new Card() { Rank = "Two", Suit = "Heart" } },
                    { "as", new Card() { Rank = "Ace", Suit = "Spade" } },
                    { "ks", new Card() { Rank = "King", Suit = "Spade" } },
                    { "qs", new Card() { Rank = "Queen", Suit = "Spade" } },
                    { "js", new Card() { Rank = "Jack", Suit = "Spade" } },
                    { "ts", new Card() { Rank = "Ten", Suit = "Spade" } },
                    { "9s", new Card() { Rank = "Nine", Suit = "Spade" } },
                    { "8s", new Card() { Rank = "Eight", Suit = "Spade" } },
                    { "7s", new Card() { Rank = "Seven", Suit = "Spade" } },
                    { "6s", new Card() { Rank = "Six", Suit = "Spade" } },
                    { "5s", new Card() { Rank = "Five", Suit = "Spade" } },
                    { "4s", new Card() { Rank = "Four", Suit = "Spade" } },
                    { "3s", new Card() { Rank = "Three", Suit = "Spade" } },
                    { "2s", new Card() { Rank = "Two", Suit = "Spade" } }
                };
            }
        }
    }
}