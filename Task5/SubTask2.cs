using Utilities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Task5
{
    public class SubTask2 : BaseTask
    {
        public override void Start()
        {
            base.Start();

            // TODO: remake with classes
            Dictionary<string, int> catFood = new Dictionary<string, int>
            {
                { "SAUSAGE", 1 },
                { "BIRD", 2 },
                { "FISH", 5 },
                { "TUNA", 8 },
                { "CATNIP", 10 },
                { "MOUSE", 20 }
            };
            TellMeWhatYouGot(catFood);
            TheFeeder(catFood);
        }

        private static void TellMeWhatYouGot(Dictionary<string, int> subject)
        {
            subject.ToList().ForEach(x => Console.WriteLine(x));
        }

        private void TheFeeder(Dictionary<string, int> subject)
        {
            var random = new Random();
            var levelOfFullness = random.Next(1, 100);
            var fullAt = random.Next(1, 100);
            Console.WriteLine($"Your cat is this full right now - {levelOfFullness}%.");
            Console.WriteLine($"It needs to be this full - {fullAt}%.");
            if (levelOfFullness > fullAt)
            {
                Console.WriteLine("Your cat is already full.");
                return;
            }
            // TODO: get rid of nesting 
            if (levelOfFullness < fullAt)
            {
                do
                {
                    var input = Console.ReadLine()?.ToUpper();
                    foreach (var (key, value) in subject)
                    {
                        if (input == key)
                        {
                            levelOfFullness += value;
                            Console.WriteLine($"Your cat is now this full - {levelOfFullness}%.");
                            break;
                        }
                    }
                } while (levelOfFullness < fullAt);
            }

            if (levelOfFullness > fullAt)
            {
                Console.WriteLine("Your cat is a fucking fat-ass - you should stop feeding it my man.");
            }

            if (levelOfFullness == fullAt)
            {
                Console.WriteLine("Your cat is full - congratulations!");
            }
        }

        // private static void Feeder(Dictionary<string, int> subject)
        // {
        //     const string defaultInput = "";
        //     var random = new Random();
        //
        //
        //     Console.WriteLine("Choose a food from the list above to feed your cat with until it`s full.");
        //     var full = random.Next(0, 100);
        //     var levelOfFullness = random.Next(0, 100);


        //     foreach (var catFood in subject)
        //     {
        //         
        //         if (levelOfFullness >= full)
        //         {
        //             Console.WriteLine("Your cat isn`t hungry anymore! Stop feeding it you retard!");
        //             break;
        //         }
        //
        //         var theChoice = Console.ReadLine() ?? defaultInput;
        //         if (theChoice == catFood.Key)
        //         {
        //             levelOfFullness += catFood.Value;
        //         }
        //         else
        //         {
        //             Console.WriteLine("Not a food!");
        //         }
        //
        //         Console.WriteLine($"Your cat is this full: {levelOfFullness}%. It needs to be at {full}% to be full.");
        //     }
        //
        //     return levelOfFullness;
        // }
    }
}