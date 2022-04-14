using System;
using System.Collections.Generic;

namespace Poker
{
    public class ComboCalculator
    {
        public ComboCalculator(List<Card> handAndDeck)
        {
            var pair = CalculatePair(handAndDeck);
            var triple = CalculateTriple(handAndDeck);
            CalculateFullHouse(triple,pair);
            CalculateFourOfAKind(handAndDeck);
            CalculateFlush(handAndDeck);
            CalculateStraight(handAndDeck);
            CalculateStraightFlush(handAndDeck);
            CalculateRoyalFlush(handAndDeck);

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
            for (var i = handAndTable.Count; i > 0; i--)
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
                                        if (handAndTable[i].suit == handAndTable[j].suit &&
                                            handAndTable[j].rankNum == handAndTable[i].rankNum + 1 &&
                                            handAndTable[j].suit == handAndTable[k].suit &&
                                            handAndTable[k].rankNum == handAndTable[j].rankNum + 1 &&
                                            handAndTable[k].suit == handAndTable[l].suit &&
                                            handAndTable[l].rankNum == handAndTable[k].rankNum + 1 &&
                                            handAndTable[l].suit == handAndTable[m].suit &&
                                            handAndTable[m].rankNum == handAndTable[l].rankNum + 1)
                                        {
                                            Console.WriteLine("Straight Flush!");
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }
        
                    for (var i = handAndTable.Count; i > 0; i--)
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
                                            handAndTable[j].rankNum == handAndTable[i].rankNum + 1 &&
                                            handAndTable[j].suit == handAndTable[k].suit &&
                                            handAndTable[k].rankNum == handAndTable[j].rankNum + 1 &&
                                            handAndTable[k].suit == handAndTable[l].suit &&
                                            handAndTable[l].rankNum == handAndTable[k].rankNum + 1 &&
                                            handAndTable[l].suit == handAndTable[m].suit &&
                                            handAndTable[m].rankNum == handAndTable[l].rankNum + 1)
                                        {
                                            Console.WriteLine("Straight Flush!");
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
        
        
        public void CalculateStraight(List<Card> handAndTable)
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
                                if (handAndTable[i].rankNum == handAndTable[j].rankNum + 1 &&
                                    handAndTable[j].rankNum == handAndTable[k].rankNum + 1 &&
                                    handAndTable[k].rankNum == handAndTable[l].rankNum + 1 &&
                                    handAndTable[l].rankNum == handAndTable[m].rankNum + 1)
                                {
                                    Console.WriteLine("Straight");
                                    break;
                                }
                            }
                        }
                    }
                }
            }

            for (var i = handAndTable.Count; i > 0; i--)
            {
                for (var j = i + 1; j < handAndTable.Count; j++)
                {
                    for (var k = j + 1; k < handAndTable.Count; k++)
                    {
                        for (var l = k + 1; l < handAndTable.Count; l++)
                        {
                            for (var m = l + 1; m < handAndTable.Count; m++)
                            {
                                if (handAndTable[i].rankNum == handAndTable[j].rankNum + 1 &&
                                    handAndTable[j].rankNum == handAndTable[k].rankNum + 1 &&
                                    handAndTable[k].rankNum == handAndTable[l].rankNum + 1 &&
                                    handAndTable[l].rankNum == handAndTable[m].rankNum + 1)
                                {
                                    Console.WriteLine("Straight");
                                    break;
                                }
                            }
                        }
                    }
                }
            }
        }
        
        
        
        
        public void CalculateRoyalFlush(List<Card> handAndTable)
                {
                    for (var i = 0; i < handAndTable.Count; i++)
                    {
                        if (handAndTable[i].rankNum == 8)
                        {
                            for (var j = i + 1; j < handAndTable.Count; j++)
                            {
                                for (var k = j + 1; k < handAndTable.Count; k++)
                                {
                                    for (var l = k + 1; l < handAndTable.Count; l++)
                                    {
                                        for (var m = l + 1; m < handAndTable.Count; m++)
                                        {
                                            if (
                                                handAndTable[j].suit == handAndTable[i].suit &&
                                                handAndTable[j].rankNum == handAndTable[i].rankNum + 1 &&
                                                handAndTable[k].suit == handAndTable[j].suit &&
                                                handAndTable[k].rankNum == handAndTable[j].rankNum + 1 &&
                                                handAndTable[l].suit == handAndTable[k].suit &&
                                                handAndTable[l].rankNum == handAndTable[j].rankNum + 1 &&
                                                handAndTable[m].suit == handAndTable[l].suit &&
                                                handAndTable[m].rankNum == handAndTable[l].rankNum + 1)
                                            {
                                                Console.WriteLine("Royal Flush!");
                                                break;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
        
                    for (var i = handAndTable.Count; i > 0; i--)
                    {
                        for (var j = i + 1; j < handAndTable.Count; j++)
                        {
                            for (var k = j + 1; k < handAndTable.Count; k++)
                            {
                                for (var l = k + 1; l < handAndTable.Count; l++)
                                {
                                    for (var m = l + 1; m < handAndTable.Count; m++)
                                    {
                                        if (handAndTable[j].rankNum == handAndTable[i].rankNum + 1 &&
                                            handAndTable[k].rankNum == handAndTable[j].rankNum + 1 &&
                                            handAndTable[l].rankNum == handAndTable[j].rankNum + 1 &&
                                            handAndTable[m].rankNum == handAndTable[l].rankNum + 1)
                                        {
                                            Console.WriteLine("Royal Flush!");
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
        
        
    
    }
    
    
    
    
}