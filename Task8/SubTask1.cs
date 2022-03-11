using Utilities;
using System;

namespace Task8
{
    public class SubTask1 : BaseTask
    {
        public override void Start()
        {
            base.Start();
            var tv = new Tv();
            Console.WriteLine(
                "If you want to go to the next channel enter the word 'Next', " +
                "if you want to go back one channel enter 'Back', if you want to go to a specific channel enter 'GoTo + number of the channel'" +
                "if you want to turn off the goddamn TV enter 'off'");
            var input = Console.ReadLine().Trim().ToUpper();
            do
            {
                if (input == "NEXT")
                {
                    tv.GoNext();
                }

                if (input == "BACK")
                {
                    tv.GoBack();
                }

                if (input == "GOTO")
                {
                    Console.WriteLine("Enter the channel number please");
                    var channelNumberEntered = int.Parse(Console.ReadLine().Trim());
                    tv.GoTo(channelNumberEntered);
                }

                Console.WriteLine("What do you want to do next?");
                input = Console.ReadLine().Trim().ToUpper();
            } while (input != "OFF");
        }
    }
}