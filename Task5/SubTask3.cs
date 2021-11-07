using Utilities;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Threading;

namespace Task5
{
    public class SubTask3 : BaseTask
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
            // var od = OrderedDictMethod(catFood);
            // var theIndices = Indexation(catFood);
           
            
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
            if (levelOfFullness < fullAt)
            {
                do
                {
                    var input = "";
                    var keys = TheListMethod(subject);
                    var i = 0;
                    var choiceRandomizer = random.Next(0, keys.Count+1);
                    foreach (var key in keys)
                    {
                        i += 1;
                        if (i == choiceRandomizer)
                        {
                            input = key;
                        }
                
                       
                    }
                    
                   
                    foreach (var (key, value) in subject)
                    {
                        if (input == key)
                        {
                            Console.WriteLine(input);
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

        private List<int> Indexation(Dictionary<string, int> subject)
        {
            var theIndexes =  new List<int>();
            foreach (var (key, value) in subject)
            {
                var index = 0;
                index++;
                theIndexes.Add(index);
            }

         
            return theIndexes;

            
        }

        private OrderedDictionary OrderedDictMethod(Dictionary<string, int> subject)
        {
            var orderedDict = new OrderedDictionary();
            var index = 0;
            foreach (var key in subject)
            {
                index += 1;
                orderedDict.Add(index, key);
            }

            return orderedDict;


        }

        private static List<string> TheListMethod(Dictionary<string, int> subject)
        {
            var keyList = subject.Keys.ToList();
            return keyList;
        }

    }
    
}