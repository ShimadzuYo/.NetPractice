﻿using System;
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
            var salaries = new List<int>();
            for (var i = 0; i < staffCount; i++)
            {
                Console.WriteLine("Enter the salary of the shitcunt!");
                var salary = int.Parse(Console.ReadLine() ?? defaultSalary);
                salaries.Add(salary);
            }

            var whoseDickIsTheBiggest = salaries.Max() - salaries.Min();
            Console.WriteLine($"{whoseDickIsTheBiggest} is the difference between the bum and the alfa.");
            if (whoseDickIsTheBiggest > 10000)
            {
                Console.WriteLine("What the fuck is this difference my man, I`m calling IRS!");
            }
            else if (whoseDickIsTheBiggest < 10000)
            {
                Console.WriteLine("You good.");
            }
        }
    }
}