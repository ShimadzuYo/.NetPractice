using System;
using System.Collections.Generic;
using System.Linq;
using Utilities;

namespace Task4
{
    public class SubTask4 : BaseTask
    {
        public override void Start()
        {
            const string defaultMinRange = "1";
            const string defaultMaxRange = "5";
            Console.WriteLine("Enter the range");
            var minRange = int.Parse(Console.ReadLine() ?? defaultMinRange);
            var maxRangeInput = int.Parse(Console.ReadLine() ?? defaultMaxRange);
            var range = (maxRangeInput + 1) - minRange;
            Console.WriteLine($"From: {minRange}");
            Console.WriteLine($"To: {maxRangeInput}");
            var theList = new List<int>();
            theList.AddRange(Enumerable.Range(minRange, range));
            OddNumSum(theList);


            static void OddNumSum(List<int> subject)
            {
                List<int> oddNums = new List<int>();
                for (var i = 0; i < subject.Count; i++)
                {
                    if (subject[i] % 2 == 1)
                    {
                        oddNums.Add(subject[i]);
                    }
                }
                Console.WriteLine($"Sum of odd numbers in range: {oddNums.Sum()}");
            }
        }
    }
}