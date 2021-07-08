using System;
using Utilities;

namespace Task1
{
    public class SubTask2 : BaseTask
    {
        public override void Start()
        {
            base.Start();
            
            Console.WriteLine("Enter Jake`s grade");
            int jakeGrade = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter John`s grade");
            int johnGrade = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Jack`s grade");
            int jackGrade = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Jane`s grade");
            int janeGrade = int.Parse(Console.ReadLine());
            AverageCalc(jackGrade, johnGrade, jackGrade, janeGrade);
        }

        static void AverageCalc(int mark1, int mark2, int mark3, int mark4)
        {
            var averageGrade = ((mark1) + (mark2) + (mark3) + (mark4)) / 4;
            Console.WriteLine($"The average grade of these retards is {averageGrade}");
        }
    }
}