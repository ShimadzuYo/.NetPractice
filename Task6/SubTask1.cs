using System;
using System.Collections.Generic;
using Utilities;

namespace Task6
{
    public class SubTask1 : BaseTask
    {
        public override void Start()
        {
            base.Start();
            var integers = new List<int>()
            {
                1, 2, -1, -2
            };
            var changedNums = new List<int>();
            int counter = 0;
            foreach (var num in integers)
            {
                
                counter++;
                var changed = Opposite(num);
                changedNums.Add(changed);
                Console.WriteLine($"{counter} entry = {num}");
            }

            foreach (var x in changedNums)
            {
                Console.WriteLine(x);
            }
        }

        private int Opposite(int subject)
        {
            var oppositeSubject = subject * -1;

            return oppositeSubject;
        }
    }
}