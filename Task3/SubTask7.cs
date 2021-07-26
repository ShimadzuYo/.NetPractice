using System;
using System.Collections.Generic;
using Utilities;

namespace Task3
{
    public class SubTask7 : BaseTask
    {
        public override void Start()
        {
            const string defaultNum = "0";
            Console.WriteLine("Enter the first number please: ");
            var num1 = int.Parse(Console.ReadLine() ?? defaultNum);
            Console.WriteLine("Enter the second number please: ");
            var num2 = int.Parse(Console.ReadLine() ?? defaultNum);
            var allTheResults = new List<int>();


            static int Max(int first, int second)
            {
                var max = 0;
                if (first > second)
                {
                    max = first;
                }
                else
                {
                    max = second;
                }

                return max;
            }

            var resultMax = Max(num1, num2);
            Console.WriteLine($"{resultMax} is the biggest of the two");

            static int Median(int first, int second)
            {
                var median = (first + second) / 2;
                return median;

            }

            var resultMedian = Median(num1, num2);
            Console.WriteLine($"And the median is {resultMedian}");
            static int Min(int first, int second)
            {
                var min = 0;
                if (first < second)
                {
                    min = first;
                }
                else
                {
                    min = second;
                }

                return min;
            }

            var resultMin = Min(num1, num2);
            Console.WriteLine($"{resultMin} is the smallest of the two");
            allTheResults.Add(resultMax);
            allTheResults.Add(resultMedian);
            allTheResults.Add(resultMin);
            foreach (var x in allTheResults)
            {
                Console.WriteLine(x);
            }
        }
    }
}