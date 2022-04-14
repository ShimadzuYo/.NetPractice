namespace Poker.ValueObjects
{
    public class Suit
    {
        public char Value { get; }

        private Suit(char suit)
        {
            Value = suit;
        }

        public static Suit Spades() => new(SpadesSuit);
        public static Suit Clubs() => new(ClubsSuit);
        public static Suit Hearts() => new(HeartsSuit);
        public static Suit Diamonds() => new(DiamondsSuit);

        public const char SpadesSuit = '\u2660';
        public const char HeartsSuit = '\u2665';
        public const char DiamondsSuit = '\u2666';
        public const char ClubsSuit = '\u2663';

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}