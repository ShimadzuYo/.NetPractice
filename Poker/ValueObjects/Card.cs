using System;

namespace Poker.ValueObjects
{
    public class Card
    {
        public Rank Rank { get; }
        public Suit Suit { get; }
        public int rankNum;

        public Card(Rank rank, Suit suit)
        {
            Rank = rank ?? throw new ArgumentNullException(nameof(rank));
            Suit = suit ?? throw new ArgumentNullException(nameof(suit));
        }

        public override string ToString()
        {
            return Rank.ToString() + Suit;
        }
    }
}