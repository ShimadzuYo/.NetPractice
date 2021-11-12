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
                    
                }

                if (input == "BACK")
                {
                    firstTv.GoBack();

                }

                if (input == "GOTO")
                {
                    firstTv.GoTo();
                    continue;
                }
            } while (input != "OFF");
        }
    }
}