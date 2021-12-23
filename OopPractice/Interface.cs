#nullable enable
using System;
using Utilities;

namespace OopPractice
{
    class Program : BaseTask
    {
        static void Main(string[] args)
        {
            const string main = "main";
            Console.WriteLine("Greetings Teacher, please enter your password: ");
            var input = Console.ReadLine();
            School.GenerateRandomGroups();
            InterfaceInitialization(input);
            Inputs();
        }

        static void InterfaceInitialization(string? input)
        {
            const string pass = "123";

            if (input == pass)
            {
                School.PrintInfo();
                Console.WriteLine(
                    "You have successfully authorized, you can see the list of the groups currently open above.\n" +
                    "Type in 'enter' = to choose a particular class to work with\n"
                );
            }
        }

        static void Inputs()
        {
            Console.WriteLine("What would you like to do?");
            var inputAfterEntering = Console.ReadLine();
            if (inputAfterEntering != "enter") return;
            Console.WriteLine("Enter group`s number please");
            var num = Int32.Parse(Console.ReadLine() ?? string.Empty);
            School.WorkWithGroup(num);
        }
    }
}