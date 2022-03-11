using System;
using System.Collections.Generic;
using Utilities;

namespace Task7
{
    public class SubTask1 : BaseTask
    {
        public override void Start()
        {
            base.Start();

            Dictionary<string, string> options = new Dictionary<string, string>()
            {
                { "Sleep in", "Wake Up" },
                { "Bolt out of the bed", "Jerk off" },
                { "Have some coffee", "Have a proper breakfast" },
                { "Walk to work", "Take a bus to work" },
                { "Say hi to people", "Ignore people" },
                { "Fuck around most of the day" , "Work as hard as you can"},
            };
            theChoice(options);
        }

        private void theChoice(Dictionary<string, string> subject)
        {
            var rand = new Random();
            foreach (var x in subject)
            {
                var theChoice = "";
                var theDie = rand.Next(1, 10);
                if (theDie < 5)
                {
                    theChoice = x.Key;
                }

                if (theDie > 5)
                {
                    theChoice = x.Value;
                }
                Console.WriteLine(theChoice);
            }
        }
    }
}