using System;

namespace TryCatchPractice
{
    public class NameTooShort : Exception
    {
        private string message = "Your name has to be at least 3 symbols long!";

        public NameTooShort()
        {
            Console.WriteLine(message);
        }
    }
}