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
            var pair = CalculatePair(handAndTable);
            var triple = CalculateTriple(handAndTable);
            CalculateFullHouse(triple, pair);
            CalculateFlush(handAndTable);
            CalculateFourOfAKind(handAndTable);
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


            // string handAndTableString = string.Join("|", handAndTable);
            // Console.WriteLine(handAndTableString);
            // string hand = string.Join("|", handAndTable.GetRange(0, handAndTable.Count / 2));
            // Console.WriteLine($"Your hand: {hand}");
            // string table = String.Join("|", handAndTable.GetRange(hand.Length-1, handAndTable.Count));
            // Console.WriteLine($"Table: {table}");

            return handAndTable;
        }

        public bool CalculatePair(List<Card> handAndTable)
        {
            bool hasPair = false;
            var pairCounter = 0;
            for (var i = 0; i < handAndTable.Count; i++)
            {
                for (var j = i + 1; j < handAndTable.Count - 1; j++)
                {
                    if (handAndTable[i].rank == handAndTable[j].rank)
                    {
                        pairCounter += 1;
                        var pairString = $"{handAndTable[i]} {handAndTable[j]}";
                        hasPair = true;
                        Console.WriteLine(pairString);
                    }
                }
            }

            if (pairCounter == 2)
            {
                Console.WriteLine($"{pairCounter} pairs!");
            }

            return hasPair;
        }

        public bool CalculateTriple(List<Card> handAndTable)
        {
            bool hasTriple = false;
            for (var i = 0; i < handAndTable.Count; i++)
            {
                for (var j = i + 1; j < handAndTable.Count; j++)
                {
                    for (var k = j + 1; k < handAndTable.Count; k++)
                    {
                        if (handAndTable[i].rank == handAndTable[j].rank &&
                            handAndTable[j].rank == handAndTable[k].rank)
                        {
                            Console.WriteLine("We got a triple!");
                            hasTriple = true;
                            break;
                        }
                    }
                }
            }

            return hasTriple;
        }

        public void CalculateFourOfAKind(List<Card> handAndTable)
        {
            for (var i = 0; i < handAndTable.Count; i++)
            {
                for (var j = i + 1; j < handAndTable.Count; j++)
                {
                    for (var k = j + 1; k < handAndTable.Count; k++)
                    {
                        for (var l = k + 1; l < handAndTable.Count; l++)
                        {
                            if (handAndTable[i].rank == handAndTable[j].rank &&
                                handAndTable[j].rank == handAndTable[k].rank &&
                                handAndTable[k].rank == handAndTable[l].rank)
                            {
                                Console.WriteLine("We got a four of a kind!");
                                break;
                            }
                        }
                    }
                }
            }
        }

        public void CalculateFlush(List<Card> handAndTable)
        {
            for (var i = 0; i < handAndTable.Count; i++)
            {
                for (var j = i + 1; j < handAndTable.Count; j++)
                {
                    for (var k = j + 1; k < handAndTable.Count; k++)
                    {
                        for (var l = k + 1; l < handAndTable.Count; l++)
                        {
                            for (var m = l + 1; m < handAndTable.Count; m++)
                            {
                                if (handAndTable[i].suit == handAndTable[j].suit &&
                                    handAndTable[j].suit == handAndTable[k].suit &&
                                    handAndTable[k].suit == handAndTable[l].suit &&
                                    handAndTable[l].suit == handAndTable[m].suit)
                                {
                                    Console.WriteLine("Flush");
                                    break;
                                }
                            }
                        }
                    }
                }
            }
        }

        public void CalculateFullHouse(bool hasTriple, bool hasPair)
        {
            if (hasTriple && hasPair)
            {
                Console.WriteLine("Full house!");
            }
        }

        public void CalculateStraightFlush(List<Card> handAndTable)
        {
            for (var i = 0; i < handAndTable.Count; i++)
            {
                for (var j = i + 1; j < handAndTable.Count; j++)
                {
                    for (var k = j + 1; k < handAndTable.Count; k++)
                    {
                        for (var l = k + 1; l < handAndTable.Count; l++)
                        {
                            for (var m = l + 1; m < handAndTable.Count; m++)
                            {
                                
                            }
                        }
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