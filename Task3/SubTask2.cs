using System;
using System.Collections.Generic;
using System.Linq;
using Utilities;

namespace Task3
{
    public class SubTask2 : BaseTask

    {
        public override void Start()
        {
            const string defaultSalary = "1000";
            const int staffCount = 3;
            var zariki = new List<int>();
            for (var i = 0; i < staffCount; i++)
            {
                Console.WriteLine("Enter the salary of the shitcunt!");
                var salary = int.Parse(Console.ReadLine() ?? defaultSalary);
                zariki.Add(salary);
            }

            static int WhoseDickIsTheBiggest(List<int> salaries)
            {
                var difference = salaries.Max() - salaries.Min();
                return difference;
            }

            var diff = WhoseDickIsTheBiggest(zariki);
            Console.WriteLine($"{diff} is the difference between the bum and the alfa.");
            if (diff > 10000)
            {
                Console.WriteLine("What the fuck is this difference my man, I`m calling IRS!");
            }
            else if (diff < 10000)
            {
                Console.WriteLine("You good.");
            }
        }
    }
}