using System;
using System.Collections.Generic;

namespace Poker
{
    public class Deck
    {
        public List<Card> cards = new();

        public readonly List<string> Ranks = new()
            {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};

        public readonly List<string> Suits = new() {"\u2660", "\u2665", "\u2666", "\u2663"};

        public Deck()
        {
            for (int i = 0; i <= 12; i++)
            {
                var heartCard = new Card();
                heartCard.suit = Suits[1];
                heartCard.rank = Ranks[i];
                heartCard.rankNum = Ranks.IndexOf(heartCard.rank);
                cards.Add(heartCard);
                var spadeCard = new Card();
                spadeCard.suit = Suits[0];
                spadeCard.rank = Ranks[i];
                spadeCard.rankNum = Ranks.IndexOf(spadeCard.rank);
                cards.Add(spadeCard);
                var clubCard = new Card();
                clubCard.suit = Suits[3];
                clubCard.rank = Ranks[i];
                clubCard.rankNum = Ranks.IndexOf(clubCard.rank);
                cards.Add(clubCard);
                var diamondCard = new Card();
                diamondCard.suit = Suits[2];
                diamondCard.rank = Ranks[i];
                diamondCard.rankNum = Ranks.IndexOf(diamondCard.rank);
                cards.Add(diamondCard);
            }
        }

        public void Print()
        {
            int num = 0;
            foreach (var card in cards)
            {
                num++;
                Console.WriteLine($"{num} {card.rank} {card.suit}");
            }

           
        }
    }
}