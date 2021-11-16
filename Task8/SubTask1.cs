using Utilities;
using System;

namespace Task8
{
    public class SubTask1 : BaseTask
    {
        public override void Start()
        {
            base.Start();
            var firstTv = new Tv();
            Console.WriteLine(
                "If you want to go to the next channel enter the word 'Next', " +
                "if you want to go back one channel enter 'Back', if you want to go to a specific channel enter 'GoTo + number of the channel'" +
                "if you want to turn off the goddamn TV enter 'off'");
            var input = Console.ReadLine().ToUpper();
            do
            {
                if (input == "NEXT")
                {
                    firstTv.GoNext();
                    Console.WriteLine("What do you want to do next?");
                    input = Console.ReadLine().ToUpper();

                }

                if (input == "BACK")
                {
                    firstTv.GoBack();
                    Console.WriteLine("What do you want to do next?");
                    input = Console.ReadLine().ToUpper();

                }

                if (input == "GOTO")
                {
                    firstTv.GoTo();
                    Console.WriteLine("What do you want to do next?");
                    input = Console.ReadLine().ToUpper();
                }
            } while (input != "OFF");
        }
    }
}