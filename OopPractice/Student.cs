using System;

namespace OopPractice
{
    public class Student
    {
        public string name;

        public DateTime StartDate;
        public DateTime EndOfCourse;
        public TimeSpan CourseLength = new TimeSpan(60, 0, 0, 0);
        public int marks;
        public int attendance;
        public const int classesAmount = 24;

        public Student(string name, DateTime StartDate)
        {
            this.name = name;
            this.StartDate = StartDate;
            EndOfCourse = StartDate + CourseLength;
        }

        public void SimulateStudent()
        {
            var rand = new Random();
            var calculatedResult = rand.Next(150, 500);
            marks = calculatedResult;
        }
    }
}