using System.Collections.Generic;

namespace Poker
{
    public interface IGame
    {
        List<Card> GiveCards(Deck deck);
       

        void Calculate(List<Card> handAndTable);
    }
}