using System;
using OopPracticeRefactored.Helpers;
using OopPracticeRefactored.UI;

namespace OopPracticeRefactored
{
    class Program
    {
        private static void Main()
        {
            var isUserAuthorized = AuthorizationMenu.TryAuthorizeUser();
            if (!isUserAuthorized)
            {
                Console.WriteLine("You failed the authorization, good bye!");
                return;
            }

            Console.WriteLine("How many groups would you like to auto-generate?");
            var userInput = Console.ReadLine();
            var couldParse = int.TryParse(userInput.NormalizeInput(), out var groupsToGenerate);
            if (!couldParse || groupsToGenerate < 1)
            {
                Console.WriteLine("You've enter invalid number, fuck you!");
                return;
            }

            var school = School.CreateWithRandomGroups(groupsToGenerate);
            
            MainMenu.StartUserInteraction(school);
        }

    }
}