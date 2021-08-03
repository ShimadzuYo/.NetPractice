using System;
using System.Collections.Generic;
using Utilities;


namespace Task3
{
    public class SubTask8 : BaseTask
    {
        public override void Start()
        {
            var ages = new List<int>();
            const string ageDefault = "1";
            Console.WriteLine("How old in days are you my man/woman?");
            var theAge = int.Parse(Console.ReadLine() ?? ageDefault);
            ages.Add(AgeInYears(theAge));
            ages.Add(AgeInMonths(theAge));
            ages.Add(AgeInDays(theAge));
            Console.WriteLine($"Years:{ages[0]}; Months: {ages[1]}; Days: {ages[2]};");
        }

        private static int AgeInYears(int age)
        {
            var inYears = age / 365;
            return inYears;
        }

        private static int AgeInMonths(int age)
        {
            var inMonths = age / 30;
            return inMonths;
        }

        private static int AgeInDays(int age)
        {
            var inDays = age * 1;
            return inDays;
        }
    }
}