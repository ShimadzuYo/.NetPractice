using System;

namespace DelegatePractice
{
    
public delegate void AccountHandler(string message);
    public class Bank
    {
        private int AccountBalance;
        private AccountHandler del;

        public Bank()
        {
            AccountBalance = 500;
        }

        public void TakeSomeMoola(int howmuch)
        {
            AccountBalance -= howmuch;
            del?.Invoke($"{AccountBalance} is your current balance.");
        }
        void RegisterDelegate(AccountHandler accountHandler)
        {
            del = accountHandler;
        }

        
    
    
    
    
    
    
    
    
    }
}