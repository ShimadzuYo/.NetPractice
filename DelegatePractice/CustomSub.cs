using System;

namespace DelegatePractice
{
    public class CustomSub
    {
        public CustomSub(Bank bank)
        {
            bank.MoneyTakenWArgs += HandleCustomEvent;
        }

        public void HandleCustomEvent(object sender, CustomEventArgs e)
        {
            Console.WriteLine($"{e.Value} has been withdrawn");
        }
    }
}