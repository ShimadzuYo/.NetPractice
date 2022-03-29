using System;
using System.Collections;
using System.Collections.Generic;

namespace Poker
{
    public class Card
    {
        public string rank;
        public string suit;

        public readonly List<string> Ranks = new List<string>()
            {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};

        public readonly List<string> Suits = new List<string>() {"\u2660", "\u2665", "\u2666", "\u2663"};

       

        public override string ToString()
        {
            return rank + suit;
        }
        
        
    }
}