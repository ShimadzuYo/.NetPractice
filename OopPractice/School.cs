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
        public static List<Group> GroupList = new();
        public static int Capacity = 10;

        // You can expose this field and make it public
        public static readonly List<string> Levels = new()
        {
            "beginner", "elementary", "pre-intermediate", "intermediate"
        };

        protected static List<string> TimeSlots = new()
        {
            "8:30", "10:00", "12:00", "14:30", "16:00"
        };


        public static void CreateAndEnterGroup()
        {
            for (int i = 0; i < Capacity; i++)
            {
                Console.WriteLine("Please enter the level: ");
                var level = Console.ReadLine();
                Console.WriteLine("Please enter the time: ");
                var timeInput = (Console.ReadLine());
                GroupList.Add(new Group(level, timeInput));
                Console.WriteLine("Would you like to continue Y or N?");
                // good point - ToUpper().Trim() - always good to 'normalize' user input 
                var answer = Console.ReadLine()?.ToUpper().Trim();
                if (answer == "N")
                {
                    break;
                }
            }
            // тут надо спросить как проверить и вывести сообщение что capacity reached
        }

        public static void PrintInfo()
        {
            var num = 0;
            foreach (var group in GroupList)
            {
                num++;
                Console.WriteLine($"{num} {group.Level} {group.Time}");
                group.Number = num;
            }
        }

        public static void AddStudent(string level, string time)
        {
            foreach (var group in GroupList)
            {
                if (level == group.Level && time == group.Time)
                {
                    Console.WriteLine($"You have chosen to edit {level} {time}. What would you like to do? ");
                    var command = Console.ReadLine()?.Trim();
                    if (command == "add")
                    {
                        group.CreateAndAddStudent();
                    }
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
        public static void GenerateRandomGroups()
        {
            var level = "";
            var time = "";
            for (var i = 0; i < Capacity; i++)
            {
                // Random object is generated on each loop iteration, better to move it outside the loop
                // so it is created once
                var rand = new Random();
                var die = rand.Next(0, Levels.Count);
                // FYI
                // if you have already 'i' name in use, better to use j and k, it's like a convention in nested loops
                // i, j, k, n, m
                // Or you could go the other way and name it meaningful
                // like here you are traversing Levels, so you can do for (var level = 0; level < Levels.Count; level)
                
                // Moreover, feels like you do not even need these loops here
                // Because when you roll a die you already have some random number
                //
                for (var a = 0; a < Levels.Count; a++)
                {
                    if (a == die)
                    {
                        level = Levels[a];
                    }
                }

                for (var b = 0; b < Levels.Count; b++)
                {
                    if (b == die)
                    {
                        time = TimeSlots[b];
                    }
                }

                var randomlyGeneratedGroup = new Group(level, time);
                GroupList.Add(randomlyGeneratedGroup);
            }
        }


        public static void WorkWithGroup(int num)
        {
            // since you are already given a num of a group you do not need traverse the groups in foreach
            // to find one to work with
            // see WorkWithGroupRefactored below
            foreach (var group in GroupList)
            {
                if (num == group.Number)
                {
                    var chosen = @group;
                    Console.WriteLine("What would you like to do?\n Class commands:\n" +
                                      "'info' = print out all the info on a group\n" +
                                      "'add' = add a student\n" +
                                      "'remove' = remove a student\n" +
                                      "'exit' = exit");
                    // better to always 'normalize' user input by doing e.g. ToUpper().Trim() (like you did above)
                    // to achieve better user experience
                    var command = Console.ReadLine();

                    do
                    {
                        switch (command)
                        {
                            case "add":
                                chosen.CreateAndAddStudent();
                                // in every action Console.WriteLine("What next?"); is repeated so you can put it in the
                                // end of the loop
                                Console.WriteLine("What next?");
                                break;
                            case "info":
                                chosen.PrintInfo();
                                Console.WriteLine("What next?");
                                break;
                            case "remove":
                                Console.WriteLine(
                                    "Please enter the name of the unfortunate sap you are trying to boot from your class:");
                                var name = Console.ReadLine();
                                chosen.RemoveStudent(name);
                                Console.WriteLine("What next?");
                                break;
                            case "simulate":
                                chosen.SimulateResults();
                                Console.WriteLine("What next?");
                                break;
                            case "results":
                                chosen.OutputResults();
                                Console.WriteLine("What next?");
                                break;
                            case "exit":
                                break;
                        }

                        command = Console.ReadLine();
                    } while (command != "exit");
                }
            }
        }

        public static void WorkWithGroupRefactored(int groupNumber)
        {
            if (groupNumber >= GroupList.Count)
            {
                Console.WriteLine("There is no such group!");
                return;
            }
            Console.WriteLine("What would you like to do?\n Class commands:\n" +
                              "'info' = print out all the info on a group\n" +
                              "'add' = add a student\n" +
                              "'remove' = remove a student\n" +
                              "'exit' = exit");
            //  -1 because user will enter like group '1', but in our list (since it is 0-based) it is group 0
            var chosenGroup = GroupList[groupNumber - 1];
            var command = Console.ReadLine()!.ToUpper().Trim();;
            while(command != "exit")
            {
                switch (command)
                {
                    case "add":
                        chosenGroup.CreateAndAddStudent();
                        break;
                    case "info":
                        chosenGroup.PrintInfo();
                        break;
                    case "remove":
                        Console.WriteLine(
                            "Please enter the name of the unfortunate sap you are trying to boot from your class:");
                        var name = Console.ReadLine()!.Trim();
                        chosenGroup.RemoveStudent(name);
                        break;
                    case "simulate":
                        chosenGroup.SimulateResults();
                        break;
                    case "results":
                        chosenGroup.OutputResults();
                        break;
                    case "exit":
                        break;
                }
                Console.WriteLine("What next?");
                command = Console.ReadLine()!.ToUpper().Trim();;
            }
        }
    }
}