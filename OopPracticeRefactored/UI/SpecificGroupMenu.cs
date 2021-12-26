using System;
using OopPracticeRefactored.Helpers;

namespace OopPracticeRefactored.UI
{
    public class SpecificGroupMenu
    {
        public static void Start(School school, int groupNumber)
        {
            UiHelpers.PrintMenuDelimiter();
            Console.WriteLine($"You are in group #{groupNumber}");
            Console.WriteLine("What would you like to do?");
            ShowCommands();
            string userInput;
            do
            {
                userInput = Console.ReadLine();
                switch (userInput.NormalizeInput())
                {
                    case "q":
                        Environment.Exit(0);
                        break;
                    case "back":
                        return;
                    case "info":
                        Console.WriteLine($"You are in the group #{groupNumber}");
                        school.PrintGroupInfo(groupNumber);
                        break;
                    case "add":
                        StudentAddMenu.Start(school, groupNumber);
                        UiHelpers.PrintMenuDelimiter();
                        Console.WriteLine($"You are in group #{groupNumber}");
                        Console.WriteLine("What would you like to do?");
                        break;
                    case "remove":
                        StudentRemoveMenu.Start(school, groupNumber);
                        UiHelpers.PrintMenuDelimiter();
                        Console.WriteLine($"You are in group #{groupNumber}");
                        Console.WriteLine("What would you like to do?");
                        break;
                    case "commands":
                        ShowCommands();
                        break;
                }
            } while (userInput.NormalizeInput() != "back");
        }

        private static void ShowCommands()
        {
            Console.WriteLine("Possible commands:\n" +
                              "'info' - print out all the info on a group\n" +
                              "'add' - add a student\n" +
                              "'remove' - remove a student\n" +
                              "'commands' - show possible commands\n" +
                              "'back' - go to previous menu\n" +
                              "'q' - exit the program");
        }
    }
}