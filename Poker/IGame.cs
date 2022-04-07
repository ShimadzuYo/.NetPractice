using System.Collections.Generic;

namespace Poker
{
    public interface IGame
    {
        List<Card> GiveCards(Deck deck);
       

        bool CalculatePair(List<Card> handAndTable);
    }
}