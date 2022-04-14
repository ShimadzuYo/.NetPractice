using System.Collections.Generic;
using Poker.ValueObjects;

namespace Poker
{
    public class HoldemComboCalculator : IComboCalculator
    {
        public const string PairComboName = "Pair";
        public const string TripleComboName = "Triple";
        public const string TwoPairsComboName = "Two pairs";
        public const string StraightComboName = "Straight";
        public const string FlushComboName = "Pair";
        public const string FullHouseComboName = "Full house";
        public const string FourOfAKindComboName = "Four of a kind";
        public const string StreetFlushComboName = "Street flush";
        public const string RoyalFlushComboName = "Royal flush";

        public List<Combo> Calculate(List<Card> handAndDeck)
        {
            var allCombos = new List<Combo>();
            allCombos.AddRange(CalculatePairs(handAndDeck));
            // var triple = CalculateTriple();
            // CalculateFullHouse(triple, pair);
            // CalculateFourOfAKind();
            // CalculateFlush();
            // CalculateStraight();
            // CalculateStraightFlush();
            // CalculateRoyalFlush();
            return allCombos;
        }

        public List<Combo> CalculatePairs(List<Card> cards)
        {
            var combos = new List<Combo>();
            for (var i = 0; i < cards.Count; i++)
            {
                for (var j = i + 1; j < cards.Count - 1; j++)
                {
                    if (cards[i].Rank == cards[j].Rank)
                    {
                        var pairCombo = new Combo(PairComboName, 0, new List<Card> {cards[i], cards[j]});
                        combos.Add(pairCombo);
                    }
                }
            }

            return combos;
        }


        // private bool CalculateTriple(List<Card> handAndDeck)
        // {
        //     bool hasTriple = false;
        //     for (var i = 0; i < handAndDeck.Count; i++)
        //     {
        //         for (var j = i + 1; j < handAndDeck.Count; j++)
        //         {
        //             for (var k = j + 1; k < handAndDeck.Count; k++)
        //             {
        //                 if (handAndDeck[i].Rank == handAndDeck[j].Rank &&
        //                     handAndDeck[j].Rank == handAndDeck[k].Rank)
        //                 {
        //                     Console.WriteLine("We got a triple!");
        //                     hasTriple = true;
        //                     break;
        //                 }
        //             }
        //         }
        //     }
        //
        //     return hasTriple;
        // }
        //
        //
        // private void CalculateFourOfAKind(List<Card> handAndDeck)
        // {
        //     for (var i = 0; i < handAndDeck.Count; i++)
        //     {
        //         for (var j = i + 1; j < handAndDeck.Count; j++)
        //         {
        //             for (var k = j + 1; k < handAndDeck.Count; k++)
        //             {
        //                 for (var l = k + 1; l < handAndDeck.Count; l++)
        //                 {
        //                     if (handAndDeck[i].Rank == handAndDeck[j].Rank &&
        //                         handAndDeck[j].Rank == handAndDeck[k].Rank &&
        //                         handAndDeck[k].Rank == handAndDeck[l].Rank)
        //                     {
        //                         Console.WriteLine("We got a four of a kind!");
        //                         break;
        //                     }
        //                 }
        //             }
        //         }
        //     }
        // }
        //
        //
        // private void CalculateFlush(List<Card> handAndDeck)
        // {
        //     for (var i = 0; i < handAndDeck.Count; i++)
        //     {
        //         for (var j = i + 1; j < handAndDeck.Count; j++)
        //         {
        //             for (var k = j + 1; k < handAndDeck.Count; k++)
        //             {
        //                 for (var l = k + 1; l < handAndDeck.Count; l++)
        //                 {
        //                     for (var m = l + 1; m < handAndDeck.Count; m++)
        //                     {
        //                         if (handAndDeck[i].suit == handAndDeck[j].suit &&
        //                             handAndDeck[j].suit == handAndDeck[k].suit &&
        //                             handAndDeck[k].suit == handAndDeck[l].suit &&
        //                             handAndDeck[l].suit == handAndDeck[m].suit)
        //                         {
        //                             Console.WriteLine("Flush");
        //                             break;
        //                         }
        //                     }
        //                 }
        //             }
        //         }
        //     }
        //
        //     for (var i = handAndDeck.Count; i > 0; i--)
        //     {
        //         for (var j = i + 1; j < handAndDeck.Count; j++)
        //         {
        //             for (var k = j + 1; k < handAndDeck.Count; k++)
        //             {
        //                 for (var l = k + 1; l < handAndDeck.Count; l++)
        //                 {
        //                     for (var m = l + 1; m < handAndDeck.Count; m++)
        //                     {
        //                         if (handAndDeck[i].suit == handAndDeck[j].suit &&
        //                             handAndDeck[j].suit == handAndDeck[k].suit &&
        //                             handAndDeck[k].suit == handAndDeck[l].suit &&
        //                             handAndDeck[l].suit == handAndDeck[m].suit)
        //                         {
        //                             Console.WriteLine("Flush");
        //                             break;
        //                         }
        //                     }
        //                 }
        //             }
        //         }
        //     }
        // }
        //
        //
        // private void CalculateFullHouse(bool hasTriple, bool hasPair)
        // {
        //     if (hasTriple && hasPair)
        //     {
        //         Console.WriteLine("Full house!");
        //     }
        // }
        //
        //
        // private void CalculateStraightFlush(List<Card> handAndDeck)
        // {
        //     for (var i = 0; i < handAndDeck.Count; i++)
        //     {
        //         for (var j = i + 1; j < handAndDeck.Count; j++)
        //         {
        //             for (var k = j + 1; k < handAndDeck.Count; k++)
        //             {
        //                 for (var l = k + 1; l < handAndDeck.Count; l++)
        //                 {
        //                     for (var m = l + 1; m < handAndDeck.Count; m++)
        //                     {
        //                         if (handAndDeck[i].suit == handAndDeck[j].suit &&
        //                             handAndDeck[j].rankNum == handAndDeck[i].rankNum + 1 &&
        //                             handAndDeck[j].suit == handAndDeck[k].suit &&
        //                             handAndDeck[k].rankNum == handAndDeck[j].rankNum + 1 &&
        //                             handAndDeck[k].suit == handAndDeck[l].suit &&
        //                             handAndDeck[l].rankNum == handAndDeck[k].rankNum + 1 &&
        //                             handAndDeck[l].suit == handAndDeck[m].suit &&
        //                             handAndDeck[m].rankNum == handAndDeck[l].rankNum + 1)
        //                         {
        //                             Console.WriteLine("Straight Flush!");
        //                             break;
        //                         }
        //                     }
        //                 }
        //             }
        //         }
        //     }
        //
        //     for (var i = handAndDeck.Count; i > 0; i--)
        //     {
        //         for (var j = i + 1; j < handAndDeck.Count; j++)
        //         {
        //             for (var k = j + 1; k < handAndDeck.Count; k++)
        //             {
        //                 for (var l = k + 1; l < handAndDeck.Count; l++)
        //                 {
        //                     for (var m = l + 1; m < handAndDeck.Count; m++)
        //                     {
        //                         if (handAndDeck[i].suit == handAndDeck[j].suit &&
        //                             handAndDeck[j].rankNum == handAndDeck[i].rankNum + 1 &&
        //                             handAndDeck[j].suit == handAndDeck[k].suit &&
        //                             handAndDeck[k].rankNum == handAndDeck[j].rankNum + 1 &&
        //                             handAndDeck[k].suit == handAndDeck[l].suit &&
        //                             handAndDeck[l].rankNum == handAndDeck[k].rankNum + 1 &&
        //                             handAndDeck[l].suit == handAndDeck[m].suit &&
        //                             handAndDeck[m].rankNum == handAndDeck[l].rankNum + 1)
        //                         {
        //                             Console.WriteLine("Straight Flush!");
        //                             break;
        //                         }
        //                     }
        //                 }
        //             }
        //         }
        //     }
        // }
        //
        //
        // private void CalculateStraight(List<Card> handAndDeck)
        // {
        //     for (var i = 0; i < handAndDeck.Count; i++)
        //     {
        //         for (var j = i + 1; j < handAndDeck.Count; j++)
        //         {
        //             for (var k = j + 1; k < handAndDeck.Count; k++)
        //             {
        //                 for (var l = k + 1; l < handAndDeck.Count; l++)
        //                 {
        //                     for (var m = l + 1; m < handAndDeck.Count; m++)
        //                     {
        //                         if (handAndDeck[i].rankNum == handAndDeck[j].rankNum + 1 &&
        //                             handAndDeck[j].rankNum == handAndDeck[k].rankNum + 1 &&
        //                             handAndDeck[k].rankNum == handAndDeck[l].rankNum + 1 &&
        //                             handAndDeck[l].rankNum == handAndDeck[m].rankNum + 1)
        //                         {
        //                             Console.WriteLine("Straight");
        //                             break;
        //                         }
        //                     }
        //                 }
        //             }
        //         }
        //     }
        //
        //     for (var i = handAndDeck.Count; i > 0; i--)
        //     {
        //         for (var j = i + 1; j < handAndDeck.Count; j++)
        //         {
        //             for (var k = j + 1; k < handAndDeck.Count; k++)
        //             {
        //                 for (var l = k + 1; l < handAndDeck.Count; l++)
        //                 {
        //                     for (var m = l + 1; m < handAndDeck.Count; m++)
        //                     {
        //                         if (handAndDeck[i].rankNum == handAndDeck[j].rankNum + 1 &&
        //                             handAndDeck[j].rankNum == handAndDeck[k].rankNum + 1 &&
        //                             handAndDeck[k].rankNum == handAndDeck[l].rankNum + 1 &&
        //                             handAndDeck[l].rankNum == handAndDeck[m].rankNum + 1)
        //                         {
        //                             Console.WriteLine("Straight");
        //                             break;
        //                         }
        //                     }
        //                 }
        //             }
        //         }
        //     }
        // }
        //
        //
        // private void CalculateRoyalFlush(List<Card> handAndDeck)
        // {
        //     for (var i = 0; i < handAndDeck.Count; i++)
        //     {
        //         if (handAndDeck[i].rankNum == 8)
        //         {
        //             for (var j = i + 1; j < handAndDeck.Count; j++)
        //             {
        //                 for (var k = j + 1; k < handAndDeck.Count; k++)
        //                 {
        //                     for (var l = k + 1; l < handAndDeck.Count; l++)
        //                     {
        //                         for (var m = l + 1; m < handAndDeck.Count; m++)
        //                         {
        //                             if (
        //                                 handAndDeck[j].suit == handAndDeck[i].suit &&
        //                                 handAndDeck[j].rankNum == handAndDeck[i].rankNum + 1 &&
        //                                 handAndDeck[k].suit == handAndDeck[j].suit &&
        //                                 handAndDeck[k].rankNum == handAndDeck[j].rankNum + 1 &&
        //                                 handAndDeck[l].suit == handAndDeck[k].suit &&
        //                                 handAndDeck[l].rankNum == handAndDeck[j].rankNum + 1 &&
        //                                 handAndDeck[m].suit == handAndDeck[l].suit &&
        //                                 handAndDeck[m].rankNum == handAndDeck[l].rankNum + 1)
        //                             {
        //                                 Console.WriteLine("Royal Flush!");
        //                                 break;
        //                             }
        //                         }
        //                     }
        //                 }
        //             }
        //         }
        //     }
        //
        //     for (var i = handAndDeck.Count; i > 0; i--)
        //     {
        //         for (var j = i + 1; j < handAndDeck.Count; j++)
        //         {
        //             for (var k = j + 1; k < handAndDeck.Count; k++)
        //             {
        //                 for (var l = k + 1; l < handAndDeck.Count; l++)
        //                 {
        //                     for (var m = l + 1; m < handAndDeck.Count; m++)
        //                     {
        //                         if (handAndDeck[j].rankNum == handAndDeck[i].rankNum + 1 &&
        //                             handAndDeck[k].rankNum == handAndDeck[j].rankNum + 1 &&
        //                             handAndDeck[l].rankNum == handAndDeck[j].rankNum + 1 &&
        //                             handAndDeck[m].rankNum == handAndDeck[l].rankNum + 1)
        //                         {
        //                             Console.WriteLine("Royal Flush!");
        //                             break;
        //                         }
        //                     }
        //                 }
        //             }
        //         }
        //     }
        // }
    }
}