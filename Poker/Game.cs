using System;
using System.Collections.Generic;

namespace Poker
{
    public class Game : IGame
    {
        private static Random rng = new Random();

        public Game()
        {
            var deck = new Deck();
            Shuffle(deck.cards);
            var handAndTable = GiveCards(deck);
            Calculate(handAndTable);
        }

        public List<Card> GiveCards(Deck deck)
        {
            var handAndTable = new List<Card>();
            for (int i = 0; i <= 9; i++)
            {
                var rand = new Random();
                var shuffler = rand.Next(0, deck.cards.Count);
                var cardToGive = deck.cards[shuffler];
                handAndTable.Add(cardToGive);
                deck.cards.Remove(cardToGive);
            }

            List<Card> hand = handAndTable.GetRange(0, 5);
            string handString = string.Join("|", hand);
            Console.WriteLine($"Your hand:\n{handString}");
            List<Card> table = handAndTable.GetRange(hand.Count, 5);
            string tableString = string.Join("|", table);
            Console.WriteLine($"Table:\n{tableString}");

            return handAndTable;
        }

        public void Calculate(List<Card> handAndTable)
        {
            var calculator = new ComboCalculator(handAndTable);
        }


        public static void Shuffle<T>(IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}