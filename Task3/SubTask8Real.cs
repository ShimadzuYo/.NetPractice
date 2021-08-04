using Utilities;
using System;
using System.Collections.Generic;


namespace Task3
{
    public class SubTask8Real: BaseTask
    {
        public override void Start()
        {
            const string ageDefault = "1";
            var theResult = new List<int>();
            Console.WriteLine("How old in days are you my man/woman?");
            var theAge = int.Parse(Console.ReadLine() ?? ageDefault);
            const int daysInYear = 365;
            const int daysInMonth = 30;
            var ageInYears = Math.DivRem(theAge,daysInYear,out var remainderMonths);
            var ageInMonths = Math.DivRem(remainderMonths,daysInMonth, out var remainderDays);
            var ageInDays = remainderDays;
            theResult.Add(ageInYears);
            theResult.Add(ageInMonths);
            theResult.Add(ageInDays);
            Console.WriteLine($"Years: {theResult[0]}; Months: {theResult[1]}; Days: {theResult[2]};");

        }

       
        private static int CalculateMonths(int age)
        {
            var ageInMonths = age / 30;
            return ageInMonths;
        }
    }
}