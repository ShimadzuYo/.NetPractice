using System.Collections.Generic;
using Poker.ValueObjects;

namespace Poker
{
    public interface IComboCalculator
    {
        List<Combo> Calculate(List<Card> cards);
    }
}