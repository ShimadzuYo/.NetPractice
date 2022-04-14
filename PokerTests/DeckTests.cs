using FluentAssertions;
using Poker;
using Xunit;

namespace PokerTests;

public class DeckTests
{
    [Fact]
    public void GivenDeck_WhenCreated_CreatedCorrectly()
    {
        // arrange &&  act
        var deck = new Deck();

        // assert
        deck.Cards.Count.Should().Be(52);
    }
}