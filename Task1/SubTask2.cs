using System;
using System.Linq;
using Utilities;

namespace Task1
{
    public class SubTask2 : BaseTask
    {
        public override void Start()
        {
            base.Start();

            const string baseValue = "2";
            Console.WriteLine("Enter Jake`s grade");
            var jakeGrade = int.Parse(Console.ReadLine() ?? baseValue);
            Console.WriteLine("Enter John`s grade");
            var johnGrade = int.Parse(Console.ReadLine() ?? baseValue);
            Console.WriteLine("Enter Jack`s grade");
            var jackGrade = int.Parse(Console.ReadLine() ?? baseValue);
            Console.WriteLine("Enter Jane`s grade");
            var janeGrade = int.Parse(Console.ReadLine() ?? baseValue);
            var result = CalculateAverage(jackGrade, johnGrade, jakeGrade, janeGrade);
            Console.WriteLine($"The average grade of these retards is {result}");
        }

        private static double CalculateAverage(params int[] marks)
        {
            return (double) marks.Sum() / marks.Length;
        }
    }
}