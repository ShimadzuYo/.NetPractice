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
            var theNumbers = new List<double>();
            const int theStopper = 0;
            const string defaultNum = "1";
            double num;
            do
            {
                var theInput = double.Parse(Console.ReadLine() ?? defaultNum);
                num = theInput;
                theNumbers.Add(num);
            } while (num != theStopper);

            theNumbers.Remove(0);
            ListCalculations(theNumbers);
        }

        private static void ListCalculations(List<double> target)
        {
            var theSum = target.Sum();
            var resultAverage = theSum / target.Count;
            Console.WriteLine($"Numbers entered:{target.Count}");
            Console.WriteLine($"Average of entered numbers is: {resultAverage}");
            Console.WriteLine($"The sum of the numbers entered is: {theSum}");
        }
    }
}