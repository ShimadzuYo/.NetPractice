using System;

namespace OopPractice
{
    public class Student
    {
        public string name;
        public string surname;
        public string status;
        public DateTime StartDate;
        public DateTime EndOfCourse;
        public TimeSpan CourseLength = new();
        
        public int Marks;
        public int HonorsMark = 400;
        public int GraduationMark = 300;
        public int ClassesAmount = 24;

        public Student(string name, string surname, DateTime startDate)
        {
            this.name = name;
            this.surname = surname;
            StartDate = startDate;
           
        }

        public void SimulateStudent()
        {
            var rand = new Random();
            var calculatedResult = rand.Next(150, 500);
            Marks = calculatedResult;

            if (Marks > GraduationMark && Marks > HonorsMark)
            {
                status = "Honors";
            }

            if (Marks > GraduationMark && Marks < HonorsMark)
            {
                status = "Graduated";
            }

            if (Marks < GraduationMark)
            {
                status = "Failed";
            }
        }

        private void StudentInfo()
        {
            Console.WriteLine($"{name} {surname} {Marks}");
        }

        public void EditStudentRefactored()
        {
            Console.WriteLine($"You have chosen to edit info on {name} {surname}");
            Console.WriteLine(
                "Student commands:\n'remove' - remove chosen student\n" +
                "'information' - output all the information on chosen student\n" +
                "'name' - change student`s name\n" +
                "'surname - change student`s surname\n'" +
                "What would you like to do?");
            var input = Console.ReadLine()?.Trim();
            switch (input)
            {
                case "information":
                    StudentInfo();
                    break;
                case "name":
                    EditName();
                    break;
                case "surname":
                    EditSurname();
                    break;
            }
        }

        private void EditName()
        {
            Console.WriteLine("Enter a new name please:");
            var newName = Console.ReadLine()?.Trim();
            name = newName;
        }

        private void EditSurname()
        {
            Console.WriteLine("Enter a new surname please: ");
            var newSurname = Console.ReadLine()?.Trim();
            surname = newSurname;
        }
    }
}