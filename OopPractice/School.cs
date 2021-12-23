using System;
using System.Collections.Generic;

namespace OopPractice
{
    public class School
    {
        public static List<Group> GroupList = new();
        public static int Capacity = 10;

        protected static readonly List<string> Levels = new()
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

        public static void GenerateRandomGroups()
        {
            var level = "";
            var time = "";
            for (var i = 0; i < Capacity; i++)
            {
                var rand = new Random();
                var die = rand.Next(0, Levels.Count);
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
                    var command = Console.ReadLine();

                    do
                    {
                        switch (command)
                        {
                            case "add":
                                chosen.CreateAndAddStudent();
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
    }
}