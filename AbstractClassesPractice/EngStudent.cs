using System;
using System.Collections.Generic;

namespace AbstractClassesPractice

{
    public class EngStudent : Student
    {
        private string name;
        private string surname;
        private int _results;
        private string status;
        private string level;
        private const int graduationMark = 100;


        private int Beginner = 20;
        private int Elementary = 30;
        private int PreIntermediate = 40;
        private int Intermediate = 55;

        private int Results
        {
            get => _results;
            
            set
            {
                _results = value;
                if (_results < graduationMark/2)
                {
                    status = "Failed";
                }

                if (_results >= graduationMark/2)
                {
                    status = "Graduated";
                }
            }
        }

        public EngStudent(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
            CalculateLevel();
            var rand = new Random();
            var simulatedResult = rand.Next(0, graduationMark);
            Results = simulatedResult;
        }


        public override void PrintInfo()
        {
            Console.WriteLine($"{name} {surname} {level} {status}");
        }

        private void CalculateLevel()
        {
            var rand = new Random();
            var levelCheckOutcome = rand.Next(0, 100);
            if (levelCheckOutcome <= Beginner)
            {
                level = "Beginner";
            }

            if (levelCheckOutcome > Beginner && levelCheckOutcome <= Elementary)
            {
                level = "Elementary";
            }

            if (levelCheckOutcome > Elementary && levelCheckOutcome <= PreIntermediate)
            {
                level = "Pre Intermediate";
            }

            if (levelCheckOutcome > PreIntermediate && levelCheckOutcome <= Intermediate)
            {
                level = "Intermediate";
            }
        }
    }
}