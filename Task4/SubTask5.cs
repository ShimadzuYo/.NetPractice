using System;
using System.Collections.Generic;
using Utilities;

namespace Task4
{
    public class SubTask5 : BaseTask
    {
        public override void Start()
        {
            base.Start();
            var fibonacci = new List<int>() {0,1};
            for (var i = 1; i < 15; i++)
            {
                var fnum = fibonacci[i] + fibonacci[i - 1];
                fibonacci.Add(fnum);
            }
            
            

            foreach (var b in fibonacci)
            {
                Console.WriteLine(b);
            }

            var forOutput = fibonacci.Count;

            for (var n = forOutput-1; n >= 0; n--)
            {
                Console.WriteLine(fibonacci[n]);
            }
        }
    }
}