namespace Poker
{
    internal static class Program
    {
        private static void Main()
        {
            IPoker poker = new HoldemPoker();
            poker.Open();
        }
    }
}