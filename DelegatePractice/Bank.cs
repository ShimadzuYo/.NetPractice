#nullable enable
using System;

namespace DelegatePractice
{
    public delegate void AccountHandler(string message);



    public class Bank
    {
        private int _accountBalance;
        private AccountHandler _del;
        private readonly Action<string> _msg = Console.WriteLine;
        public int howmuch;

        public int Howmuch
        {
            get => howmuch;
            set => howmuch = value;
        }

        private int _counterForWithdrawals;
        public event Action MoneyTaken;
        public event EventHandler<CustomEventArgs> MoneyTakenWArgs;

        public Bank()
        {
            _accountBalance = 1000;
            Howmuch = howmuch;
        }


        public void TakeSomeMoola(int howmuch)
        {
            this.howmuch = howmuch;
            if (this.howmuch > _accountBalance || _accountBalance <= 0)
            {
                _msg($"Insufficient funds, your current balance is {_accountBalance}");
                return;
            }

            _accountBalance -= this.howmuch;
            OnMoneyTaken();
            OnMoneyTakenWArgs(new CustomEventArgs(this.howmuch));
            _del?.Invoke($"{_accountBalance} is your current balance.");
            
        }

        public void RegisterDelegate(AccountHandler accountHandler)
        {
            _del = accountHandler;
        }

        protected virtual void OnMoneyTaken()
        {
            MoneyTaken?.Invoke();
        }

        protected virtual void OnMoneyTakenWArgs(CustomEventArgs e)
        {
            e.Value += howmuch;

            MoneyTakenWArgs?.Invoke(this, e);
        }
        
        
    }
}