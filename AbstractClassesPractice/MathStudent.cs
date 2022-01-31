using System;

namespace AbstractClassesPractice
{
    public class MathStudent : Student
    {
        private const int _honorsGrade = 200;
        private const int _passingGrade = 150;
        private string status ="Hui";
        private readonly string name;
        private readonly string surname;
        private int _results;

        private int Results
        {
            set
            {
                _results = value;
                if (_results >= _passingGrade)
                {
                    status = "Passed";
                }

                status = _results switch
                {
                    > _passingGrade and > _honorsGrade => "Passed with honors",
                    < _passingGrade => "Failed",
                    _ => status
                };
            }
        }
        public MathStudent(string name, string surname, int result)
        {
            Results = result;
            this.name = name;
            this.surname = surname;
            
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"{name} {surname} {_results} {status}");
        }
    }
}