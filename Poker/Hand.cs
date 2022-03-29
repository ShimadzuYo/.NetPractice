using System;
using System.Collections.Generic;

namespace Poker
{
    public class Hand 
    {
        public List<Card> hand = new();


        public Hand(Deck deck)
        {
            for (int i = 0; i <= 4; i++)
            {
                var rand = new Random();
                var handFillerRand = rand.Next(0, deck.cards.Count);
                hand.Add(deck.cards[handFillerRand]);
            }
        }


        

        public string ConcatenateCards()
        {
            string cardsOutput = String.Join("|", hand);
            return cardsOutput;
        }

        
    }
}