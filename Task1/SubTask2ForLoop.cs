using System;
using System.Collections.Generic;
using System.Linq;
using Utilities;


namespace Task1

{
    public class SubTask2ForLoop : BaseTask

    {
        public override void Start()
        {
            base.Start();
            var retards = new List<string> { };
            var classSizeDefault = "5";
            var defaultMark = "2";
            var marks = new List<int>();
            Console.WriteLine("How many students do you have?");
            var classSize = int.Parse(Console.ReadLine() ?? classSizeDefault);
            for (var i = 0; i < classSize; i++)
            {
                Console.WriteLine("Enter students` name please");
                string name = Console.ReadLine();
                retards.Add(name);
                Console.WriteLine("Enter their mark");
                var mark = int.Parse(Console.ReadLine() ?? defaultMark);
                marks.Add(mark);
            }

            var calculatedResult = (double) marks.Sum() / marks.Count;
            Console.WriteLine($"Here is their average score: {calculatedResult}");
        }
    }
}