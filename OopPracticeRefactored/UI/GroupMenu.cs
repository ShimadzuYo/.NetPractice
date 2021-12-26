using System;
using OopPracticeRefactored.Helpers;

namespace OopPracticeRefactored.UI
{
    public static class GroupMenu
    {
        public static void StartGroupMenuInteraction(School school)
        {
            UiHelpers.PrintMenuDelimiter();
            Console.WriteLine("You have entered groups menu");
            ShowCommands();
            string userInput;
            do
            {
                userInput = Console.ReadLine();
                if (userInput.NormalizeInput() == "q")
                    Environment.Exit(0);

                if (userInput.NormalizeInput() == "back")
                    return;

                var isUserInputNumber = int.TryParse(userInput, out var groupNumber);
                if (!isUserInputNumber)
                    Console.WriteLine("Please enter a valid group number");
                else
                {
                    if (groupNumber - 1 >= school.GroupCount())
                    {
                        Console.WriteLine("There is no such group!");
                        continue;
                    }
                    SpecificGroupMenu.Start(school, groupNumber);
                    UiHelpers.PrintMenuDelimiter();
                    Console.WriteLine("You are back to groups menu.");
                    ShowCommands();
                }
            } while (userInput.NormalizeInput() != "back");
        }
        

        private static void ShowCommands()
        {
            Console.WriteLine("Possible commands:\n" +
                              "'back' - to go back to the main menu\n" +
                              "N - where N is the group number you'd like to enter\n" + 
                              "'q' - exit the program");
            Console.WriteLine("Please enter a group number");
        }
        
    }
}