using System;
using System.Collections.Generic;
using Poker.ValueObjects;

namespace Poker
{
    public class Combo
    {
        public string Name { get; set; }
        public int Priority { get; set; }
        public List<Card> _cards { get; set; }

        public Combo(string name, int priority, List<Card> cards)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Priority = priority;
            _cards = cards ?? throw new ArgumentNullException(nameof(cards));
        }
    }
}