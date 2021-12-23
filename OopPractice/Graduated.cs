using System;

namespace OopPractice
{
    public class Graduated : Student
    {
        public string status;
        public int marks;


        public Graduated(string name, DateTime StartDate) : base(name, StartDate)
        {
            
        }
    }


}