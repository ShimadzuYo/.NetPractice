using System;
using Utilities;

namespace Task2
{
    public class SubTask3 : BaseTask
    {
        public override void Start()
        {
            base.Start();

            string[] valueNames = {"first", "second", "third"};
            var values = new int [3];
            // i = 0, i = 1, i = 2, i = 3 ( i <= 3)
            // i = 0, i = 1, i = 2 ( i < 3)
            for (var i = 0; i < values.Length; i++)
            {
                Console.WriteLine($"Enter the {valueNames[i]} value");
                values[i] = int.Parse(Console.ReadLine() ?? string.Empty);
            }

            Console.WriteLine("Enter key of the element for comparison");

            var index = int.Parse(Console.ReadLine() ?? string.Empty);
            for (var i = 0; i < values.Length; i++)
            {
                Console.WriteLine($"{values[index]} > {values[i]} = {values[index] > values[i]}");
            }
        }
    }
}