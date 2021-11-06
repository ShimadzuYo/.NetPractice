// using System;
// using System.Collections.Generic;
// using Utilities;
//
// namespace Task7
// {
//     public class SubTask1Rec : BaseTask
//     {
//         public override void Start()
//         {
//             var theDay = new List<string>();
//
//             base.Start();
//         }
//
//
//         private List<string> ChooseAction(int min, int max)
//         {
//             var actions = new Dictionary<string, string>()
//             {
//                 { "Sleep in", "Wake Up" },
//                 { "Bolt out of the bed", "Jerk off" },
//                 { "Have some coffee", "Have a proper breakfast" },
//                 { "Walk to work", "Take a bus to work" },
//                 { "Say hi to people", "Ignore people" },
//                 { "Fuck around most of the day", "Work as hard as you can" },
//             };
//             var beginning = "Начало дня";
//             var end = "Конец дня";
//             var theChoice = beginning;
//             Console.WriteLine(theChoice);
//             var rand = new Random();
//             var theDecision = rand.Next(min, max);
//             var schedule = new List<string>();
//             schedule.Add(theChoice);
//             if (theDecision > 1 && theDecision < 5)
//             {
//                 theChoice == 
//             }
//             if (theChoice == "Конец дня")
//             {
//                 return schedule;
//             }
//             
//         }
//     }
// }