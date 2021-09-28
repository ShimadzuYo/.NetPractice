using System;
using System.Collections.Generic;
using System.Linq;
using Utilities;


namespace Task5
{
    public class SubTask1 : BaseTask

    {
        public override void Start()
        {
            Dictionary<string, double> catFood = new Dictionary<string, double>
            {
                { "Shit", 1 },
                { "Piss", 1.5 },
                { "Canned tuna", 5 }
            };
            TellMeWhatYouGot(catFood);
        }

        private void TellMeWhatYouGot(Dictionary<string, double> subject)
        {
            subject.ToList().ForEach(x=>Console.WriteLine(x));
            
        }
    }
}