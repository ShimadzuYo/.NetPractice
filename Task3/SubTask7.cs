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
            var allResults = new List<double>();

            var max = num1 > num2 ? num1 : num2;
            Console.WriteLine($"{max} is the biggest of the two");

            var min = Min(num1, num2);

            Console.WriteLine($"{min} is the smallest of the two");

            var average  = (num1 + num2) / 2.0;;
            
            Console.WriteLine($"{average} is the median");

            allResults.Add(max);
            allResults.Add(min);
            allResults.Add(average);

            foreach (var result in allResults)
            {
                Console.WriteLine(result);
            }
        }

        private static int Min(int first, int second) => first < second ? first : second;
    }
}