using System;

namespace OopPractice
{
    public class Graduated : Student
    {
        private string  status = "Graduated";
        public int marks;
        private int attendance;


        public Graduated(string name, string surname, DateTime StartDate, int marks) : base(name, surname, StartDate)
        {
            this.marks = marks;
        }


        public new void SimulateStudent()
        {
            var rand = new Random();
            var attended = rand.Next(0, ClassesAmount);
            if (attended < ClassesAmount / 5)
            {
                status = "Graduated without certificate";
            }
        }
       
    }


}