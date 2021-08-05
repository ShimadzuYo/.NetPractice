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
            base.Start();
            const string defaultSalary = "1000";
            const int staffCount = 3;
            var zariki = new List<int>();
            for (var i = 0; i < staffCount; i++)
            {
                Console.WriteLine("Enter the salary of the shitcunt!");
                var salary = int.Parse(Console.ReadLine() ?? defaultSalary);
                zariki.Add(salary);
            }

            Maximum(zariki);

            var diff = Maximum(zariki);
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

        // private static int WhoseDickIsTheBiggest(IReadOnlyList<int> sals)
        // {
        //     var tempMax = sals[0];
        //     var tempMin = sals[0];
        //     for (var x = 0; x < sals.Count - 1; x++)
        //     {
        //         if (x < sals[x + 1])
        //         {
        //             tempMin = x;
        //         }
        //         else if (x > sals[x + 1])
        //         {
        //             tempMax = x;
        //         }
        //     }
        //
        //     var difference = tempMax - tempMin;
        //
        //     return difference;
        // }

        private static int Maximum(List<int> gavno)
        {
            var max = gavno[0];
            var min = gavno[0];
            for (var i = 1; i < gavno.Count; i++)
            {
                if (gavno[i] > max)
                {
                    max = gavno[i];
                }

                if (gavno[i] < min)
                {
                    min = gavno[i];
                }
            }

            return max - min;
        }
    }
}