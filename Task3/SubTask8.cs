using Utilities;
using System;
using System.Collections.Generic;


namespace Task3
{
    public class SubTask8Real : BaseTask
    {
        public override void Start()
        {
            base.Start();
            const string ageDefault = "1";
            var theResult = new List<int>();
            Console.WriteLine("How old in days are you my man/woman?");
            var ageInDays = int.Parse(Console.ReadLine() ?? ageDefault);
            const int daysInYear = 365;
            const int daysInMonth = 30;
            var ageInYears = Math.DivRem(ageInDays, daysInYear, out var remainderMonths);
            var ageInMonths = Math.DivRem(remainderMonths, daysInMonth, out var remainderDays);
            var daysLeft = remainderDays;
            theResult.Add(ageInYears);
            theResult.Add(ageInMonths);
            theResult.Add(daysLeft);
            Console.WriteLine($"Years: {theResult[0]}; Months: {theResult[1]}; Days: {theResult[2]};");
        }
    }
}