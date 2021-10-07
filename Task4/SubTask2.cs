using System;
using System.Collections.Generic;
using Utilities;

namespace Task4
{
    public class SubTask2 : BaseTask
    {
        public override void Start()
        {
            base.Start();
            const int topEnd = 9;
            const string defaultValue = "1";
            Console.WriteLine("Enter the value please:");
            var theInput = int.Parse(Console.ReadLine() ?? defaultValue);
            for (var i = 0; i < topEnd; i++)
            {
                var multiplicationResult = theInput * (i + 1);
                Console.WriteLine($"{theInput} * {i + 1} = {multiplicationResult}");
            }
        }
    }
}