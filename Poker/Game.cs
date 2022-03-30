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
            CalculateCombos(handAndTable);
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

            Console.WriteLine("Your hand and table: ");


            string handOutput = String.Join("|", handAndTable);
            Console.WriteLine(handOutput);


            return handAndTable;
        }

        public void CalculateCombos(List<Card> handAndTable)
        {
            for (var i = 0; i < handAndTable.Count; i++)
            {
                for (var j = i + 1; j < handAndTable.Count; j++)
                {
                    if (handAndTable[i].rank == handAndTable[j].rank)
                    {
                        var pairInString = $"{handAndTable[i]} {handAndTable[j]}";
                        Console.WriteLine(pairInString);
                    }
                }
            }
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