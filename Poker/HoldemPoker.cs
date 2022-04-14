using System;
using System.Collections.Generic;
using System.Linq;
using Poker.ValueObjects;

namespace Poker
{
    public class HoldemPoker : IPoker
    {
        private Deck Deck { get; }
        private List<Card> Hand { get; }
        private List<Card> Table { get; }
        private List<Card> HandAndTable { get; }
        private readonly IComboCalculator _comboCalculator;

        public HoldemPoker()
        {
            _comboCalculator = new HoldemComboCalculator();
            Deck = new Deck();
            Hand = Deck.Cards.Take(2).ToList();
            Table = Deck.Cards.Skip(2).Take(5).ToList();
            HandAndTable = Hand.Concat(Table).ToList();
        }

        public void CalculateCombos()
        {
            _comboCalculator.Calculate(HandAndTable);
        }

        public void Open()
        {
            var handString = string.Join("|", Hand);
            Console.WriteLine($"Your hand:\n{handString}");

            var tableString = string.Join("|", Table);
            Console.WriteLine($"Table:\n{tableString}");
        }
    }
}