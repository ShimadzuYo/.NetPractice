using System;
using System.Collections.Generic;
using System.Linq;
using Poker.ValueObjects;

namespace Poker
{
    public class Deck
    {
        private static readonly Random Rng = new();
        public List<Card> Cards { get; }

        public Deck()
        {
            Cards = new List<Card>
            {
                new(Rank.Two(), Suit.Clubs()),
                new(Rank.Three(), Suit.Clubs()),
                new(Rank.Four(), Suit.Clubs()),
                new(Rank.Five(), Suit.Clubs()),
                new(Rank.Six(), Suit.Clubs()),
                new(Rank.Seven(), Suit.Clubs()),
                new(Rank.Eight(), Suit.Clubs()),
                new(Rank.Nine(), Suit.Clubs()),
                new(Rank.Ten(), Suit.Clubs()),
                new(Rank.Jack(), Suit.Clubs()),
                new(Rank.Queen(), Suit.Clubs()),
                new(Rank.King(), Suit.Clubs()),
                new(Rank.Ace(), Suit.Clubs()),

                new(Rank.Two(), Suit.Hearts()),
                new(Rank.Three(), Suit.Hearts()),
                new(Rank.Four(), Suit.Hearts()),
                new(Rank.Five(), Suit.Hearts()),
                new(Rank.Six(), Suit.Hearts()),
                new(Rank.Seven(), Suit.Hearts()),
                new(Rank.Eight(), Suit.Hearts()),
                new(Rank.Nine(), Suit.Hearts()),
                new(Rank.Ten(), Suit.Hearts()),
                new(Rank.Jack(), Suit.Hearts()),
                new(Rank.Queen(), Suit.Hearts()),
                new(Rank.King(), Suit.Hearts()),
                new(Rank.Ace(), Suit.Hearts()),

                new(Rank.Two(), Suit.Diamonds()),
                new(Rank.Three(), Suit.Diamonds()),
                new(Rank.Four(), Suit.Diamonds()),
                new(Rank.Five(), Suit.Diamonds()),
                new(Rank.Six(), Suit.Diamonds()),
                new(Rank.Seven(), Suit.Diamonds()),
                new(Rank.Eight(), Suit.Diamonds()),
                new(Rank.Nine(), Suit.Diamonds()),
                new(Rank.Ten(), Suit.Diamonds()),
                new(Rank.Jack(), Suit.Diamonds()),
                new(Rank.Queen(), Suit.Diamonds()),
                new(Rank.King(), Suit.Diamonds()),
                new(Rank.Ace(), Suit.Diamonds()),

                new(Rank.Two(), Suit.Spades()),
                new(Rank.Three(), Suit.Spades()),
                new(Rank.Four(), Suit.Spades()),
                new(Rank.Five(), Suit.Spades()),
                new(Rank.Six(), Suit.Spades()),
                new(Rank.Seven(), Suit.Spades()),
                new(Rank.Eight(), Suit.Spades()),
                new(Rank.Nine(), Suit.Spades()),
                new(Rank.Ten(), Suit.Spades()),
                new(Rank.Jack(), Suit.Spades()),
                new(Rank.Queen(), Suit.Spades()),
                new(Rank.King(), Suit.Spades()),
                new(Rank.Ace(), Suit.Spades()),
            }.OrderBy(x => Rng.Next()).ToList();
        }
    }
}