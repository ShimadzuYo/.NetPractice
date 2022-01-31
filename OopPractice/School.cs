using System;
using System.Collections.Generic;

namespace OopPractice
{
    public class School
    {
        // better to make it private, because you are usually exposing some methods to work with group
        // and do not allow user to directly access internals of the 'School'
        // Usually you expose some methods that introduce logic to make sure your 'School' is always in a valid state
        // E.g. 'public' in this case allows someone to write School.GroupList = new List<Student>()
        // that would basically 'break' the school
        // to avoid that you do not usually expose internals of your school by making fields 'private'
        private static List<Group> GroupList = new();
        public static int EngGroupsCap = 10;
        public static int MathGroupCap = 5;
        private const int Pass = 123;

        // You can expose this field and make it public


        public void Start()
        {
            for (int i = 0; i < EngGroupsCap; i++)
            {
                var randomEngGroup = new EnglishGroup();
                randomEngGroup.GenerateRandomEngGroup();
                randomEngGroup.Number = i + 1;
                GroupList.Add(randomEngGroup);
            }

            for (int i = 0; i < MathGroupCap; i++)
            {
                var randomMathGroup = new MathGroup();
                randomMathGroup.GenerateRandomMathGroup();
                randomMathGroup.Number = i + 1;
                GroupList.Add(randomMathGroup);
            }


            Console.WriteLine("Greetings Teacher, please enter your password: ");
            var passwordInput = int.Parse(Console.ReadLine() ?? string.Empty);

            if (passwordInput == Pass)
            {
                PrintGroups();
                Console.WriteLine("You have successfully authorized, you can see all active groups above\n" +
                                  "Here are the commands you can enter to start working with groups:\n" +
                                  "'enter' - edit particular group\n" +
                                  "'exit' - go back to main menu");
                var command = Console.ReadLine();
                switch (command)
                {
                    case "enter":
                        Console.WriteLine("Enter group`s number please:");
                        var number = int.Parse(Console.ReadLine() ?? string.Empty);
                        if (number > EngGroupsCap)
                        {
                            Console.WriteLine("There is no such group!");
                        }

                        var chosenGroup = GroupList[number - 1];
                        chosenGroup.WorkWithGroupRefactored();
                        break;
                    case "exit":
                        break;
                }
            }
        }


        // FYI
        // Here, it sounds generally logical like method on School that allows to create some random groups inside of it
        // However, in programming it is better to always divide components have as less responsibilities as possible
        // Like in this case as I understood. A school object encapsulates and aggregates groups of students and exposes a user
        // some methods to manipulate those groups
        // There is a pattern in programming called 'Factory' that you could utilize here
        // But that's also questionable and purely depends on your domain, the program, and how it is going to be used


        public void PrintGroups()
        {
            foreach (var group in GroupList)
            {
                switch (@group)
                {
                    case MathGroup:
                        Console.WriteLine($"Math {@group.Number} {@group.Time} {@group.Level}");
                        break;
                    case EnglishGroup:
                        Console.WriteLine($"English {@group.Number} {@group.Time} {@group.Level}");
                        break;
                }
            }
        }
    }
}