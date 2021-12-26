using System;
using OopPracticeRefactored.Helpers;

namespace OopPracticeRefactored.UI
{
    public static class MainMenu
    {
        // TODO: add command to create a new group
        public static void StartUserInteraction(School school)
        {
            UiHelpers.PrintMenuDelimiter();
            Console.WriteLine("You have the following groups:");
            school.PrintGroupsWithStudents();
            Console.WriteLine("What would you like to do?\n");
            ShowCommands();
            string userInput;
            do
            {
                userInput = Console.ReadLine().NormalizeInput();
                switch (userInput)
                {
                    case "info":
                        school.PrintGroupsWithStudents();
                        break;
                    case "groups":
                        GroupMenu.StartGroupMenuInteraction(school);
                        UiHelpers.PrintMenuDelimiter();
                        Console.WriteLine("You are back to main menu");
                        ShowCommands();
                        break;
                    case "results":
                        school.PrintStudentsResults();
                        break;
                    case "commands":
                        ShowCommands();
                        break;
                    default:
                        Console.WriteLine("Unknown command");
                        break;
                }
            } while (userInput.NormalizeInput() != "q");
        }

        private static void ShowCommands()
        {
            Console.WriteLine("Possible commands:\n" +
                              "'info' - print all groups\n" +
                              "'groups' - enter groups menu\n" +
                              "'results' - show students graduation result\n" +
                              "'commands' - show possible commands\n" +
                              "'q' - exit the program");
        }
    }
}