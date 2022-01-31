using System;

namespace OopPractice
{
    public class MathStudent: Student
    {
        private TimeSpan courseLength = new TimeSpan(30, 0, 0, 0);
        public MathStudent(string name, string surname, DateTime startDate) : base(name, surname, startDate)
        {
            
        }
    }
}