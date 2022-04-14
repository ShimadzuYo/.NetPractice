using System;

namespace Poker.ValueObjects
{
    public class Rank
    {
        public string Value { get; }

        public Rank(string value)
        {
            Value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static Rank Two() => new(TwoRank);
        public static Rank Three() => new(ThreeRank);
        public static Rank Four() => new(FourRank);
        public static Rank Five() => new(FiveRank);
        public static Rank Six() => new(SixRank);
        public static Rank Seven() => new(SevenRank);
        public static Rank Eight() => new(EightRank);
        public static Rank Nine() => new(NineRank);
        public static Rank Ten() => new(TenRank);
        public static Rank Jack() => new(JackRank);
        public static Rank Queen() => new(QueenRank);
        public static Rank King() => new(KingRank);
        public static Rank Ace() => new(AceRank);

        public const string TwoRank = "2";
        public const string ThreeRank = "3";
        public const string FourRank = "4";
        public const string FiveRank = "5";
        public const string SixRank = "6";
        public const string SevenRank = "7";
        public const string EightRank = "8";
        public const string NineRank = "9";
        public const string TenRank = "10";
        public const string JackRank = "J";
        public const string QueenRank = "Q";
        public const string KingRank = "K";
        public const string AceRank = "A";

        public override string ToString()
        {
            return Value;
        }
    }
}