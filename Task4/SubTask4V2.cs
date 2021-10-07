using Utilities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Task4
{
    public class SubTask4V2 : BaseTask
    {
        public override void Start()
        {
            base.Start();
            const string defaultMinRange = "1";
            const string defaultMaxRange = "5";
            Console.WriteLine("Enter the range");
            var minRange = int.Parse(Console.ReadLine() ?? defaultMinRange);
            var maxRangeInput = int.Parse(Console.ReadLine() ?? defaultMaxRange);
            Console.WriteLine($"From {minRange} to {maxRangeInput}");
            var theResult = OddNumSum(minRange, maxRangeInput);
            Console.WriteLine($"The sum of all the odd numbers is {theResult}");
        }

        private static int OddNumSum(int minRange, int maxRange)
        {
            int oddSum = 0;
            var numbers = Enumerable.Range(minRange, maxRange);
            foreach (var number in numbers)
            {
                if (number % 2 != 0)
                {
                    oddSum += number;
                }
            }

            return oddSum;
        }

        // private static void OddNumSum(int minRange, int maxRange)
        // {
        //     var range = (maxRange + 1) - minRange;
        //     var theList = new List<int>();
        //     var oddList = new List<int>();
        //     theList.AddRange(Enumerable.Range(minRange, range));
        //     foreach (var member in theList)
        //     {
        //         if (member % 2 != 0)
        //         {
        //             oddList.Add(member);
        //         }
        //     }
        //
        //     Console.WriteLine($"The sum of odds is {oddList.Sum()}");
        // }
    }
}