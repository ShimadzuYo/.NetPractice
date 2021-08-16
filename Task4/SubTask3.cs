using System;
using System.Collections.Generic;
using System.Linq;
using Utilities;

namespace Task4
{
    public class SubTask3 : BaseTask
    {
        public override void Start()
        {
            base.Start();
            var theNumbers = new List<int>();
            const int theStopper = 0;
            const string defaultNum = "1";
            var num = new int();
            do
            {
                var theInput = int.Parse(Console.ReadLine() ?? defaultNum);
                num = theInput;
                theNumbers.Add(num);
            } while (num != theStopper);
            Action(theNumbers);
        }

        private void Action(List<int> target)
        {
            var theListWithoutZero = new List<int>();
            for (var i = 0; i < target.Count - 1; i++)
            {
                theListWithoutZero.Add(target[i]);
            }

            var resultAverage = theListWithoutZero.Sum() / theListWithoutZero.Count;
            Console.WriteLine($"Numbers entered:{theListWithoutZero.Count}");
            Console.WriteLine($"Average of entered numbers is: {resultAverage}");
            Console.WriteLine($"The sum of the numbers entered is: {theListWithoutZero.Sum()}");
        }
    }
}