using System.Collections.Generic;

namespace Poker
{
    public interface IGame
    {
        List<Card> GiveCards(Deck deck);
       

        void CalculateCombos(List<Card> handAndTable);
    }
}