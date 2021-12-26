using System;

namespace OopPracticeRefactored.UI
{
    public static class AuthorizationMenu
    {
        private const string Pass = "123";
        private const int MaximumPasswordInputAttempts = 3;

        public static bool TryAuthorizeUser()
        {
            Console.WriteLine("Greetings Teacher, please enter your password: ");

            for (var attemptNumber = 1; attemptNumber <= MaximumPasswordInputAttempts; attemptNumber++)
            {
                var password = Console.ReadLine();
                if (password == Pass)
                    return true;
                Console.WriteLine("Invalid password, please try again. " +
                                  $"You have {MaximumPasswordInputAttempts - attemptNumber} attempts left");
            }

            return false;
        }
    }
}