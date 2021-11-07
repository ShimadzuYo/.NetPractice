using System;
using System.Collections.Generic;
using Utilities;

namespace Task6
{
    public class SubTask4 : BaseTask
    {
        public override void Start()
        {
            base.Start();
            var nums = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };
            TheJob(nums);
        }

        private static void TheJob(List<int> subject)
        {
            for (var i = subject.Count - 1; i == 0; i--)
            {
                Console.WriteLine(subject[i]);
            }
        }
    }
}